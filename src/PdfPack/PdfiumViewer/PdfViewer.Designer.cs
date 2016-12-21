using System;
using System.Collections.Generic;
using System.Text;

namespace PdfiumViewer
{
    partial class PdfViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._container = new System.Windows.Forms.SplitContainer();
            this._bookmarks = new PdfiumViewer.NativeTreeView();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._saveButton = new System.Windows.Forms.ToolStripButton();
            this._printButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._zoomInButton = new System.Windows.Forms.ToolStripButton();
            this._zoomOutButton = new System.Windows.Forms.ToolStripButton();
            this._container.Panel1.SuspendLayout();
            this._container.SuspendLayout();
            this._toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _container
            // 
            this._container.Dock = System.Windows.Forms.DockStyle.Fill;
            this._container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._container.Location = new System.Drawing.Point(0, 25);
            this._container.Name = "_container";
            // 
            // _container.Panel1
            // 
            this._container.Panel1.Controls.Add(this._bookmarks);
            this._container.Size = new System.Drawing.Size(588, 379);
            this._container.SplitterDistance = 200;
            this._container.TabIndex = 2;
            this._container.TabStop = false;
            // 
            // _bookmarks
            // 
            this._bookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bookmarks.FullRowSelect = true;
            this._bookmarks.Location = new System.Drawing.Point(0, 0);
            this._bookmarks.Name = "_bookmarks";
            this._bookmarks.ShowLines = false;
            this._bookmarks.Size = new System.Drawing.Size(200, 379);
            this._bookmarks.TabIndex = 0;
            this._bookmarks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._bookmarks_AfterSelect);
            // 
            // _toolStrip
            // 
            this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._saveButton,
            this._printButton,
            this.toolStripSeparator1,
            this._zoomInButton,
            this._zoomOutButton});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(588, 25);
            this._toolStrip.TabIndex = 0;
            // 
            // _saveButton
            // 
            this._saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(23, 22);
            this._saveButton.Text = "Save";
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // _printButton
            // 
            this._printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._printButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._printButton.Name = "_printButton";
            this._printButton.Size = new System.Drawing.Size(23, 22);
            this._printButton.Text = "Print";
            this._printButton.Click += new System.EventHandler(this._printButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _zoomInButton
            // 
            this._zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._zoomInButton.Name = "_zoomInButton";
            this._zoomInButton.Size = new System.Drawing.Size(23, 22);
            this._zoomInButton.Text = "Zoom In";
            this._zoomInButton.Click += new System.EventHandler(this._zoomInButton_Click);
            // 
            // _zoomOutButton
            // 
            this._zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._zoomOutButton.Name = "_zoomOutButton";
            this._zoomOutButton.Size = new System.Drawing.Size(23, 22);
            this._zoomOutButton.Text = "Zoom Out";
            this._zoomOutButton.Click += new System.EventHandler(this._zoomOutButton_Click);
            // 
            // PdfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._container);
            this.Controls.Add(this._toolStrip);
            this.Name = "PdfViewer";
            this.Size = new System.Drawing.Size(588, 404);
            this._container.Panel1.ResumeLayout(false);
            this._container.ResumeLayout(false);
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _saveButton;
        private System.Windows.Forms.ToolStripButton _printButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _zoomInButton;
        private System.Windows.Forms.ToolStripButton _zoomOutButton;
        private System.Windows.Forms.SplitContainer _container;
        private NativeTreeView _bookmarks;
        private PdfRenderer _renderer;
    }
}
