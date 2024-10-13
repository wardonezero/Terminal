namespace Pack.Shared;
[Flags]
public enum WonderOfTheAnciantWorld : byte
{
    None = 0b_0000_0000,//0
    GreatPyramidofGiza = 0b_0000_0001,//1
    HangingGardensofBabylon = 0b_0000_0010,//2
    StatueofZeusatOlympia = 0b_0000_0100,//4
    TempleofArtemisatEphesus = 0b_0000_1000,//8
    MausoleumatHalicarnassus = 0b_0001_0000,//16
    ColossusofRhodes = 0b_0010_0000,//32
    LighthouseofAlexandria = 0b_0100_0000,//64 32 + 64 = 0b_0110_0000 = 96
}