using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TagLib.WavPack;

namespace WavMerger
{
    class Program
    {
        public static string[] words;
        public static string source;
        public static string destination;

        static void Main(string[] args)
        {
            while (true)
            {
                int folderAddCount = 0, folderMakeCount = 0, fileAddCount = 0;

                //get file source and destination paths
                Console.Write("Source: ");
                source = Console.ReadLine();
                Console.Write("Destination: ");
                destination = Console.ReadLine();

                words = System.IO.Directory.GetFiles(source);

                //might try to replace with a "lambda"? expression later
                //make words just the file names
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = Path.GetFileNameWithoutExtension(words[i]);
                }

                for (int i = 0; i < words.Length; i++)
                {
                    //if folder of word exists
                    if (System.IO.Directory.Exists(destination + "\\" + words[i]))
                    {
                        bool exists = false;
                        for (int x = 0; x < System.IO.Directory.GetFiles(destination + "\\" + words[i]).Length; x++)
                        {
                            if (ArtistMatch(source + "\\" + words[i] + ".wav", destination + "\\" + words[i] + "\\" + (x + 1) + ".wav"))
                            {
                                exists = true;
                                break;
                            }
                        }
                        //move file to folder and rename it
                        if (!exists)
                        {
                            System.IO.File.Move(source + "\\" + words[i] + ".wav", destination + "\\" + words[i] + "\\" + (System.IO.Directory.GetFiles(destination + "\\" + words[i]).Length + 1) + ".wav");
                            folderAddCount++;
                        }

                    }
                    else if (System.IO.File.Exists(destination + "\\" + words[i] + ".wav")) //if file of same word exists
                    {
                        if (!ArtistMatch(source + "\\" + words[i] + ".wav", destination + "\\" + words[i] + ".wav"))
                        {
                            System.IO.Directory.CreateDirectory(destination + "\\" + words[i]); //create new folder
                            System.IO.File.Move(destination + "\\" + words[i] + ".wav", destination + "\\" + words[i] + "\\1.wav"); //move old file
                            System.IO.File.Move(source + "\\" + words[i] + ".wav", destination + "\\" + words[i] + "\\2.wav"); //move new file
                            folderMakeCount++;
                        }
                    }
                    else //if word does not exist
                    {
                        System.IO.File.Move(source + "\\" + words[i] + ".wav", destination + "\\" + words[i] + ".wav");
                        fileAddCount++;
                    }
                }

                Console.WriteLine("Folders added to: " + folderAddCount);
                Console.WriteLine("Folders created: " + folderMakeCount);
                Console.WriteLine("Files added: " + fileAddCount);
                Console.WriteLine();
            }
        }

        public static bool ArtistMatch(string fileOne, string fileTwo)
        {
            TagLib.File f1 = TagLib.File.Create(fileOne);
            TagLib.File f2 = TagLib.File.Create(fileTwo);

            return f1.Tag.AlbumArtists[0] == f2.Tag.AlbumArtists[0];
        }
    }
}
