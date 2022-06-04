using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader;

public partial class FileDetailsForm : Form
{
    public FileDetailsForm(string title, string author)
    {
        InitializeComponent();
        txtBoxTitle.Text = title;
        txtBoxArtist.Text = author;
    }


    private void txtBoxArtist_TextChanged(object sender, EventArgs e)
    {
        SetFileNameLabel();
    }

    private void txtBoxTitle_TextChanged(object sender, EventArgs e)
    {
        SetFileNameLabel();
    }

    private void SetFileNameLabel()
    {
        lblFileName.Text = $"{txtBoxArtist.Text} - {txtBoxTitle.Text}";
    }

    public string GetArtist()
    {
        return txtBoxArtist.Text;
    }

    public string GetTitle()
    {
        return txtBoxTitle.Text;
    }

    public string GetFileName()
    {
        return lblFileName.Text;
    }

    private void btnFileDetailsConfirm_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

