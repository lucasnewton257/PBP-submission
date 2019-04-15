
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem {

    //this method uses a BinaryFormatter object to create a binary file that will store the players stats by serializing data
    public static void savePlayer(HealthPL player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.LOL";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    //this method checks to see if there is already a save file and if there is the method will deserialize data and this will load the player
    public static PlayerData loadPlayer()
    {
        string path = Application.persistentDataPath + "/player.LOL";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = (PlayerData)formatter.Deserialize(stream);
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

    //this method will delete the save file if there is already one that exist.
    public static void DeleteSave()
    {
        string path = Application.persistentDataPath + "/player.LOL";
        if (path != null)
        {
            File.Delete(path);
            
        }
    }
}
