using Tinoco14.Droid;
using Tinoco14.Interfaces;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigDatabase))]
namespace Tinoco14.Droid
{
    public class ConfigDatabase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}