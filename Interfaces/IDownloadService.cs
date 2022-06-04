using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.Interfaces;

public interface IDownloadService
{
    void DownloadMp3(string youtubeLink);
    void DownloadMp4(string youtubeLink);
}

