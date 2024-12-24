﻿using AoC2023;
using System.Buffers.Binary;
using System.Collections;

var fullInput =
@"x00: 1
x01: 1
x02: 0
x03: 0
x04: 0
x05: 1
x06: 0
x07: 1
x08: 1
x09: 0
x10: 1
x11: 0
x12: 0
x13: 1
x14: 0
x15: 1
x16: 0
x17: 1
x18: 1
x19: 1
x20: 1
x21: 0
x22: 0
x23: 1
x24: 1
x25: 0
x26: 0
x27: 1
x28: 1
x29: 1
x30: 1
x31: 0
x32: 0
x33: 1
x34: 0
x35: 1
x36: 0
x37: 1
x38: 0
x39: 0
x40: 1
x41: 1
x42: 0
x43: 1
x44: 1
y00: 1
y01: 0
y02: 1
y03: 1
y04: 0
y05: 0
y06: 1
y07: 1
y08: 0
y09: 1
y10: 1
y11: 1
y12: 1
y13: 1
y14: 0
y15: 1
y16: 1
y17: 0
y18: 1
y19: 0
y20: 0
y21: 1
y22: 1
y23: 1
y24: 1
y25: 0
y26: 1
y27: 0
y28: 0
y29: 1
y30: 1
y31: 1
y32: 1
y33: 1
y34: 0
y35: 1
y36: 0
y37: 1
y38: 1
y39: 0
y40: 0
y41: 0
y42: 0
y43: 1
y44: 1

mrg XOR wrd -> z32
x36 AND y36 -> pfc
sqk AND jcq -> bmc
tfh AND nkd -> jrd
x19 XOR y19 -> mcv
x39 XOR y39 -> ksf
rtb AND whc -> jsf
x00 XOR y00 -> z00
vjg XOR jgc -> z37
y02 XOR x02 -> qpd
mrg AND wrd -> vcm
x34 XOR y34 -> bgg
nbb OR vjc -> bwm
y25 AND x25 -> dbt
vmj AND wtw -> nbw
vcd OR vch -> nhh
pmg AND rnc -> dmp
y21 XOR x21 -> sbs
wbw AND qwr -> dqm
gdt XOR nsb -> z43
nsb AND gdt -> dnc
x09 XOR y09 -> mnm
x28 AND y28 -> shp
x10 XOR y10 -> cvv
kdn AND pbv -> mhd
sgk XOR krk -> z41
gwh AND cvv -> pgn
x06 XOR y06 -> hsn
dfq OR dbt -> kgs
x25 XOR y25 -> nfm
mcv XOR ppf -> z19
x36 XOR y36 -> dkj
dtn OR nnq -> svk
dkj XOR dmj -> z36
y41 AND x41 -> kfp
y40 AND x40 -> qhf
hnj OR bmc -> kpf
dmj AND dkj -> vnw
y04 AND x04 -> dtn
x38 XOR y38 -> spg
spg XOR bwb -> z38
fjr OR jgh -> whc
pjg OR cvk -> z45
y30 AND x30 -> rvc
qwt XOR nhk -> z40
nth OR rvc -> mwg
rtb XOR whc -> z28
sgk AND krk -> qvv
x38 AND y38 -> crp
svk XOR sfn -> z05
jrd OR ktg -> bgh
x23 XOR y23 -> gcj
y07 AND x07 -> vjc
jct OR hvf -> nhk
nfm AND vsw -> dfq
y44 AND x44 -> cvk
pfc OR vnw -> jgc
mjf AND qrw -> jgh
gcj AND grk -> cdw
gvt OR hhb -> tjc
nfm XOR vsw -> z25
spg AND bwb -> wjg
bgh AND pvj -> vcd
jcq XOR sqk -> z01
y31 XOR x31 -> tkw
pmg XOR rnc -> z33
x11 AND y11 -> cbm
x43 AND y43 -> bmf
kgk AND sbs -> z21
kvw AND bgg -> gwm
x17 XOR y17 -> tdb
kfp OR qvv -> pwt
y37 AND x37 -> nbc
y42 AND x42 -> qjp
x29 AND y29 -> bqn
hbn OR dmp -> kvw
y10 AND x10 -> bcw
x21 AND y21 -> knb
x16 XOR y16 -> vgb
y20 AND x20 -> vwh
cjh XOR hsn -> z06
grk XOR gcj -> z23
sbn AND pwt -> qwg
mnm XOR gqb -> gwh
tdh XOR jrb -> z44
y04 XOR x04 -> ptv
vwh OR vvc -> kgk
wtw XOR vmj -> z29
jrb AND tdh -> pjg
jbp AND wtc -> pfh
y27 XOR x27 -> qrw
tkw AND mwg -> vmq
x29 XOR y29 -> wtw
x44 XOR y44 -> jrb
qwg OR qjp -> gdt
x28 XOR y28 -> rtb
y16 AND x16 -> fhn
pfh OR gpq -> ppf
kgs AND jkt -> wtd
nhh XOR vgb -> z16
x26 AND y26 -> jck
nhk AND qwt -> qwh
gjv AND wcs -> nbb
ksf AND wjf -> hvf
y27 AND x27 -> fjr
qgc AND bqb -> nth
bwm XOR jhr -> z08
jgf AND htr -> dmc
nrw OR cdw -> pbv
kpf XOR qpd -> z02
htr XOR jgf -> z12
y13 AND x13 -> wbw
x43 XOR y43 -> nsb
hrr OR rtt -> bdk
bcw OR pgn -> jbk
bgg XOR kvw -> z34
y18 AND x18 -> gpq
vjg AND jgc -> mqh
y23 AND x23 -> nrw
fpk OR ffh -> wtc
ctv XOR tdb -> z17
y33 XOR x33 -> pmg
x24 AND y24 -> frv
ppf AND mcv -> gvt
kdn XOR pbv -> z24
y03 AND x03 -> rtt
btr OR fhn -> ctv
bwm AND jhr -> tvw
wcs XOR gjv -> z07
vcm OR ttt -> rnc
jck OR wtd -> mjf
gqb AND mnm -> dsk
wtc XOR jbp -> z18
nbc OR mqh -> bwb
y05 XOR x05 -> sfn
fkt OR wnq -> cjh
y14 XOR x14 -> tfh
x40 XOR y40 -> qwt
y02 AND x02 -> tng
y24 XOR x24 -> kdn
knd OR hds -> wcs
x39 AND y39 -> z39
y15 AND x15 -> vch
crp OR wjg -> wjf
y26 XOR x26 -> jkt
y35 XOR x35 -> prn
x12 XOR y12 -> htr
pwt XOR sbn -> z42
gpp OR vmq -> mrg
dsk OR ptc -> z09
cbm OR hgb -> jgf
frv OR mhd -> vsw
x09 AND y09 -> ptc
y34 AND x34 -> rkq
dqm OR wgb -> nkd
x00 AND y00 -> jcq
drv OR qph -> dmj
bgh XOR pvj -> z15
vdc AND tjc -> vvc
x41 XOR y41 -> krk
dmc OR njd -> qwr
wjf XOR ksf -> jct
ptv XOR bdk -> z04
x42 XOR y42 -> sbn
tpv AND npk -> hrr
x14 AND y14 -> ktg
x22 XOR y22 -> qgd
bqb XOR qgc -> z30
kpf AND qpd -> pwk
vdc XOR tjc -> z20
y18 XOR x18 -> jbp
x19 AND y19 -> hhb
x22 AND y22 -> dpg
jsf OR shp -> vmj
y15 XOR x15 -> pvj
dpg OR vsb -> grk
prn AND bhd -> drv
bhd XOR prn -> z35
qgd AND tvj -> vsb
y32 XOR x32 -> wrd
tvw OR qpg -> gqb
nkd XOR tfh -> z14
ksb XOR jbk -> z11
vgb AND nhh -> btr
y06 AND x06 -> knd
cjh AND hsn -> hds
dnc OR bmf -> tdh
nbw OR bqn -> bqb
tpv XOR npk -> z03
x20 XOR y20 -> vdc
x32 AND y32 -> ttt
y13 XOR x13 -> wgb
x12 AND y12 -> njd
y35 AND x35 -> qph
tdb AND ctv -> ffh
x03 XOR y03 -> npk
qrw XOR mjf -> z27
y30 XOR x30 -> qgc
y08 AND x08 -> qpg
x08 XOR y08 -> jhr
tng OR pwk -> tpv
cvv XOR gwh -> z10
mwg XOR tkw -> z31
kgk XOR sbs -> rcb
x17 AND y17 -> fpk
qwr XOR wbw -> z13
y07 XOR x07 -> gjv
x33 AND y33 -> hbn
ksb AND jbk -> hgb
x01 XOR y01 -> sqk
x11 XOR y11 -> ksb
rcb OR knb -> tvj
jkt XOR kgs -> z26
qhf OR qwh -> sgk
y31 AND x31 -> gpp
sfn AND svk -> wnq
ptv AND bdk -> nnq
x01 AND y01 -> hnj
x05 AND y05 -> fkt
qgd XOR tvj -> z22
rkq OR gwm -> bhd
x37 XOR y37 -> vjg";

var smallInput =
@"x00: 1
x01: 0
x02: 1
x03: 1
x04: 0
y00: 1
y01: 1
y02: 1
y03: 1
y04: 1

ntg XOR fgs -> mjb
y02 OR x01 -> tnw
kwq OR kpj -> z05
x00 OR x03 -> fst
tgd XOR rvg -> z01
vdt OR tnw -> bfw
bfw AND frj -> z10
ffh OR nrd -> bqk
y00 AND y03 -> djm
y03 OR y00 -> psh
bqk OR frj -> z08
tnw OR fst -> frj
gnj AND tgd -> z11
bfw XOR mjb -> z00
x03 OR x00 -> vdt
gnj AND wpb -> z02
x04 AND y00 -> kjc
djm OR pbm -> qhw
nrd AND vdt -> hwm
kjc AND fst -> rvg
y04 OR y02 -> fgs
y01 AND x02 -> pbm
ntg OR kjc -> kwq
psh XOR fgs -> tgd
qhw XOR tgd -> z09
pbm OR djm -> kpj
x03 XOR y03 -> ffh
x00 XOR y04 -> ntg
bfw OR bqk -> z06
nrd XOR fgs -> wpb
frj XOR qhw -> z04
bqk OR frj -> z07
y03 OR x01 -> nrd
hwm AND bqk -> z03
tgd XOR rvg -> z12
tnw OR pbm -> gnj";

var maybeBroken1 =
@"x00: 0
x01: 1
x02: 0
x03: 1
x04: 0
x05: 1
y00: 0
y01: 0
y02: 1
y03: 1
y04: 0
y05: 1

x00 AND y00 -> z05
x01 AND y01 -> z02
x02 AND y02 -> z01
x03 AND y03 -> z03
x04 AND y04 -> z04
x05 AND y05 -> z00";

var maybeBroken2 =
@"x00: 0
x01: 1
x02: 0
x03: 1
x04: 0
x05: 1
y00: 0
y01: 0
y02: 1
y03: 1
y04: 0
y05: 1

x00 AND y00 -> z00
x01 AND y01 -> z01
x02 AND y02 -> z02
x03 AND y03 -> z03
x04 AND y04 -> z04
x05 AND y05 -> z05";

var smallest2 =
@"x00: 1
x01: 1
x02: 1
y00: 0
y01: 1
y02: 0

x00 AND y00 -> z00
x01 XOR y01 -> z01
x02 OR y02 -> z02";

var smallest3 =
@"x00: 1
x01: 1
x02: 0
x03: 1
y00: 1
y01: 0
y02: 1
y03: 1";


var smallest4 =
@"x00: 1
x01: 1
x02: 1
y00: 0
y01: 1
y02: 0

x00 AND y00 -> z00
x01 XOR y01 -> z01
x02 OR y02 -> z02";

var input = smallInput;
input = fullInput;
input = maybeBroken1;
input = maybeBroken2;
//input = smallest2;
//input = smallest3;
//input = smallest4;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0l;

var split = input.Split(Environment.NewLine);
var states = split.TakeWhile(x => x != "").Select(x => x.Split(": ")).ToDictionary(x => x[0], x => x[1] == "1");
var connections = split.Skip(states.Count + 1).Select(x => x.Split(new[] { " -> ", " " }, StringSplitOptions.None)).Select(x => new Connection { A = x[0], Op = x[1], B = x[2], C = x[3] });



//Console.WriteLine($"13? {GetNumber2(new bool[] { true, true, false, true })}");
//Console.WriteLine($"21? {GetNumber2(new bool[] { false, true, false, true, false, true })}");


Console.WriteLine($"X {GetNumber('x')}");
Console.WriteLine($"Y {GetNumber('y')}");
Console.WriteLine($"Target {GetNumber('x') + GetNumber('y')}");

//foreach (var item in connections)
//{

//    Console.WriteLine($"{item.A} -- {item.C}");
//    Console.WriteLine($"{item.B} -- {item.C}");
//}

long GetNumber(char c)
{
    var xxx = states.Where(x => x.Key.StartsWith(c)).OrderBy(x => x.Key).ToList();
    var zs = xxx.Select(x => x.Value)/*.Reverse()*/.ToArray();

    return GetNumber2(zs);
}


long GetNumber2(bool[] a)
{
    var sum = 0L;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i])
        {
            sum += (long)Math.Pow(2, i);
        }
    }
    return sum;
}

var visited = new HashSet<string>();
while (connections.Count() > visited.Count)
{
    foreach (var connection in connections)
    {
        var hash = connection.ToString();
        if (visited.Contains(hash)) { continue; }
        if (!(states.ContainsKey(connection.A) && states.ContainsKey(connection.B))) { continue; }
        if (connection.Op == "AND") { states[connection.C] = states[connection.A] && states[connection.B]; }
        if (connection.Op == "XOR") { states[connection.C] = states[connection.A] ^ states[connection.B]; }
        if (connection.Op == "OR") { states[connection.C] = states[connection.A] || states[connection.B]; }
        visited.Add(hash);
        break;
    }
}

result = GetNumber('z');

timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();



class Connection
{
    public string A { get; set; }
    public string B { get; set; }
    public string C { get; set; }
    public string Op { get; set; }
    public override string ToString() => $"{A} {Op} {B} -> {C}";

    public Connection Clone() => new Connection { A = A, B = B, C = C, Op = Op };
}