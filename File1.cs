using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class File1 : Form
    {
        private readonly BindingList<FilePairRow> rows = new();

        public File1()
        {
            InitializeComponent();
            gridFiles.DataSource = rows;
            btnBrowseLeft.Click += (_, _) => PickFolder(txtFolderLeft);
            btnBrowseRight.Click += (_, _) => PickFolder(txtFolderRight);
            btnRefresh.Click += (_, _) => RefreshRows();
            gridFiles.SelectionChanged += (_, _) => UpdateInfo();
            Load += (_, _) => RefreshRows();
        }

        private static void PickFolder(TextBox t)
        {
            using var dlg = new FolderBrowserDialog();
            if (Directory.Exists(t.Text)) dlg.SelectedPath = t.Text;
            if (dlg.ShowDialog() == DialogResult.OK) t.Text = dlg.SelectedPath;
        }

        private void RefreshRows()
        {
            var left = GetFiles(txtFolderLeft.Text);
            var right = GetFiles(txtFolderRight.Text);
            rows.RaiseListChangedEvents = false;
            rows.Clear();
            int max = Math.Max(left.Count, right.Count);
            for (int i = 0; i < max; i++)
                rows.Add(FilePairRow.From(
                    i < left.Count ? left[i] : null,
                    i < right.Count ? right[i] : null));
            rows.RaiseListChangedEvents = true;
            rows.ResetBindings();
            lblInfo.Text = $"Папка 1: {left.Count} файлов | Папка 2: {right.Count} файлов";
        }

        private static List<FileInfo> GetFiles(string path)
        {
            var list = new List<FileInfo>();
            if (!Directory.Exists(path)) return list;
            try { list.AddRange(new DirectoryInfo(path).GetFiles()); } catch { }
            return list;
        }

        private void UpdateInfo()
        {
            if (gridFiles.CurrentRow?.DataBoundItem is not FilePairRow row) { lblInfo.Text = ""; return; }
            lblInfo.Text = $"Левый:  {FmtFile(row.LeftFullPath)}\r\nПравый: {FmtFile(row.RightFullPath)}";
        }

        private static string FmtFile(string? p)
        {
            if (string.IsNullOrWhiteSpace(p)) return "(нет)";
            if (!File.Exists(p)) return "(не найден)";
            var fi = new FileInfo(p);
            return $"{fi.Name} | {fi.Length} байт | создан: {fi.CreationTime:dd.MM.yyyy HH:mm}";
        }

        internal sealed class FilePairRow
        {
            public string LeftName { get; set; } = "";
            public long? LeftSize { get; set; }
            public DateTime? LeftCreated { get; set; }
            public string LeftFullPath { get; set; } = "";

            public string RightName { get; set; } = "";
            public long? RightSize { get; set; }
            public DateTime? RightCreated { get; set; }
            public string RightFullPath { get; set; } = "";

            public static FilePairRow From(FileInfo? l, FileInfo? r) => new()
            {
                LeftName = l?.Name ?? "",
                LeftSize = l?.Exists == true ? l.Length : null,
                LeftCreated = l?.Exists == true ? l.CreationTime : null,
                LeftFullPath = l?.FullName ?? "",

                RightName = r?.Name ?? "",
                RightSize = r?.Exists == true ? r.Length : null,
                RightCreated = r?.Exists == true ? r.CreationTime : null,
                RightFullPath = r?.FullName ?? "",
            };
        }
    }
}

