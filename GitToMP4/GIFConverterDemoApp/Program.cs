// See https://aka.ms/new-console-template for more information
using GIFConverter;

Console.WriteLine("Started converting GIF to MP4 using FFmpeg");

var converter = new Converter(@"ffmpeg");

if (converter.Convert(@"D:\test.gif", @"D:\test.mp4"))
{
    Console.WriteLine("Success");
} else
{
    Console.WriteLine("Fail");
}


Console.WriteLine("Ended converting.");
Console.ReadLine();