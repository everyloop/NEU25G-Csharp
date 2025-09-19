
//using (FileStream stream = File.OpenWrite("myFile.bin"))
//{
//	for (int i = 0; i <= 255; i++)
//	{
//		stream.WriteByte((byte)i);
//	}
//}

using (FileStream stream = File.OpenRead("myFile.bin"))
{
    byte[] data = new byte[stream.Length];
    stream.Read(data, 0, data.Length);

    for (int i = 0; i < data.Length; i++)
    {
        Console.Write(data[i].ToString("X2") + "  ");

        if (i % 16 == 15)
        {
            Console.WriteLine();
        }
    }
}

