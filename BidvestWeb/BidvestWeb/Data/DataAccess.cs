using BidvestWeb.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BidvestWeb.Data
{
    public static class DataAccess
    {
        public static List<Profile> GetDataFromJsonFile(string jsonFile)
        {
            List<Profile> profileFromJson;
            if (File.Exists(jsonFile))
            {
                try
                {
                    string jsonFromFile;
                    using (var reader = new StreamReader(jsonFile))
                    {
                        jsonFromFile = reader.ReadToEnd();
                    }
                    profileFromJson = JsonConvert.DeserializeObject<List<Profile>>(jsonFromFile);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                throw new Exception("File not found");
            }
            return profileFromJson;

        }

        
    }
}
