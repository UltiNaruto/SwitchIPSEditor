using System.Text;

namespace SwitchIPSEditor
{
    public class IPS
    {
        const string IPSHeader = "PATCH";
        const string IPSFooter = "EOF";
        const UInt32 IPSAddressOffset = 0xFFF00;

        public class Patch
        {
            public UInt32 Address;
            public byte[]? Datas;
        }

        public static void Save(string filename, params Patch[] patches)
        {
            using (var writer = new BinaryWriter(File.Open(filename, FileMode.Create, FileAccess.Write)))
            {
                writer.Write(Encoding.UTF8.GetBytes(IPSHeader, 0, 5));
                foreach (var patch in patches)
                {
                    if (patch.Datas != null)
                    {
                        writer.Write((patch.Address - IPSAddressOffset).Get3Bytes(false));
                        writer.Write('\x00');
                        writer.Write((byte)patch.Datas.Length);
                        foreach (var data in patch.Datas) writer.Write(data);
                    }
                }
                writer.Write(Encoding.UTF8.GetBytes(IPSFooter, 0, 3));
            }
        }

        public static Patch[] Load(string filename)
        {
            Patch? patch = default(Patch);
            List<Patch> patches = new List<Patch>();

            using (var reader = new BinaryReader(File.OpenRead(filename)))
            {
                if (Encoding.UTF8.GetString(reader.ReadBytes(5)) != IPSHeader)
                    throw new Exception("Invalid IPS file (Header not found)!");
                while(reader.BaseStream.Position < reader.BaseStream.Length - 3)
                {
                    patch = new Patch();
                    patch.Address = reader.ReadBytes(3).ToUInt24(false) + IPSAddressOffset;
                    reader.ReadByte();
                    patch.Datas = reader.ReadBytes(reader.ReadByte());
                    patches.Add(patch);
                }
                if (Encoding.UTF8.GetString(reader.ReadBytes(3)) != IPSFooter)
                    throw new Exception("Invalid IPS file (End of file not found)!");
            }
            return patches.ToArray();
        }
    }
}
