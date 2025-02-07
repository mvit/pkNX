using System;
using System.IO;

namespace pkNX.Structures;

public class Maison6Trainer
{
    public ushort Class;
    public ushort Count;
    public ushort[] Choices;

    public Maison6Trainer() { }

    public Maison6Trainer(byte[] data)
    {
        Class = BitConverter.ToUInt16(data, 0);
        Count = BitConverter.ToUInt16(data, 2);
        Choices = new ushort[Count];
        for (int i = 0; i < Count; i++)
            Choices[i] = BitConverter.ToUInt16(data, 4 + (2 * i));
    }

    public byte[] Write()
    {
        using var ms = new MemoryStream();
        using var bw = new BinaryWriter(ms);
        bw.Write(Class);
        bw.Write(Count);
        foreach (ushort Choice in Choices)
            bw.Write(Choice);
        return ms.ToArray();
    }
}

public class Maison6Pokemon
{
    public ushort Species;
    public readonly ushort[] Moves = new ushort[4];
    private readonly byte EV;
    public readonly bool[] EVs = new bool[6];
    public byte Nature;
    public ushort Item;
    public ushort Form;

    public int Move1 { get => Moves[0]; set => Moves[0] = (ushort)value; }
    public int Move2 { get => Moves[1]; set => Moves[1] = (ushort)value; }
    public int Move3 { get => Moves[2]; set => Moves[2] = (ushort)value; }
    public int Move4 { get => Moves[3]; set => Moves[3] = (ushort)value; }
    public bool HP { get => EVs[0]; set => EVs[0] = value; }
    public bool ATK { get => EVs[1]; set => EVs[1] = value; }
    public bool DEF { get => EVs[2]; set => EVs[2] = value; }
    public bool SPE { get => EVs[3]; set => EVs[3] = value; }
    public bool SPA { get => EVs[4]; set => EVs[4] = value; }
    public bool SPD { get => EVs[5]; set => EVs[5] = value; }

    public Maison6Pokemon(byte[] data)
    {
        Species = BitConverter.ToUInt16(data, 0);
        for (int i = 0; i < 4; i++)
            Moves[i] = BitConverter.ToUInt16(data, 2 + (2 * i));
        EV = data[0xA];
        for (int i = 0; i < 6; i++)
            EVs[i] = ((EV >> i) & 1) == 1;
        Nature = data[0xB];
        Item = BitConverter.ToUInt16(data, 0xC);
        Form = BitConverter.ToUInt16(data, 0xE);
    }

    public byte[] Write()
    {
        using var ms = new MemoryStream();
        using var bw = new BinaryWriter(ms);
        bw.Write(Species);
        foreach (ushort Move in Moves)
            bw.Write(Move);

        int ev = EV & 0xC0;
        for (int i = 0; i < EVs.Length; i++)
            ev |= EVs[i] ? 1 << i : 0;
        bw.Write((byte)ev);

        bw.Write(Nature);
        bw.Write(Item);
        bw.Write(Form);
        return ms.ToArray();
    }
}
