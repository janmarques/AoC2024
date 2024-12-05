﻿using System.Reflection.Emit;
using System.Runtime.CompilerServices;

var fullInput =
@"11|42
53|45
53|81
21|97
21|88
21|22
29|27
29|78
29|81
29|66
64|63
64|52
64|92
64|82
64|72
56|36
56|29
56|78
56|73
56|55
56|84
59|18
59|14
59|13
59|19
59|88
59|75
59|16
42|41
42|16
42|53
42|56
42|52
42|59
42|88
42|29
13|43
13|79
13|11
13|97
13|27
13|45
13|42
13|66
13|21
16|18
16|78
16|41
16|75
16|13
16|68
16|54
16|82
16|84
16|88
79|36
79|52
79|82
79|63
79|53
79|75
79|72
79|91
79|78
79|18
79|73
68|69
68|76
68|32
68|45
68|27
68|42
68|66
68|21
68|71
68|11
68|54
68|95
72|92
72|66
72|65
72|13
72|68
72|71
72|76
72|81
72|21
72|73
72|11
72|15
72|54
78|66
78|81
78|69
78|92
78|94
78|71
78|53
78|36
78|33
78|14
78|82
78|27
78|13
78|93
52|75
52|29
52|18
52|27
52|14
52|72
52|68
52|91
52|73
52|93
52|54
52|78
52|94
52|84
52|19
54|76
54|85
54|63
54|33
54|65
54|66
54|97
54|79
54|69
54|42
54|64
54|11
54|95
54|55
54|27
54|71
95|43
95|59
95|85
95|97
95|79
95|29
95|96
95|75
95|91
95|42
95|16
95|63
95|41
95|88
95|78
95|64
95|32
55|45
55|52
55|18
55|91
55|79
55|64
55|59
55|41
55|63
55|96
55|85
55|16
55|42
55|95
55|76
55|43
55|22
55|97
85|22
85|16
85|41
85|78
85|79
85|63
85|14
85|32
85|29
85|97
85|53
85|56
85|91
85|59
85|52
85|43
85|19
85|96
85|75
14|71
14|65
14|84
14|93
14|54
14|45
14|42
14|76
14|13
14|81
14|27
14|94
14|68
14|11
14|95
14|82
14|15
14|66
14|69
14|73
32|75
32|41
32|19
32|36
32|43
32|14
32|96
32|52
32|59
32|79
32|72
32|78
32|53
32|29
32|63
32|56
32|82
32|64
32|84
32|91
32|22
27|71
27|16
27|43
27|45
27|64
27|79
27|96
27|42
27|21
27|81
27|63
27|11
27|66
27|85
27|33
27|55
27|15
27|69
27|97
27|65
27|76
27|59
36|53
36|94
36|54
36|76
36|45
36|15
36|73
36|65
36|13
36|92
36|69
36|82
36|84
36|33
36|93
36|81
36|55
36|72
36|14
36|27
36|71
36|66
36|11
15|42
15|91
15|41
15|65
15|97
15|22
15|43
15|18
15|64
15|79
15|21
15|96
15|32
15|76
15|11
15|88
15|85
15|95
15|52
15|63
15|59
15|56
15|16
15|45
19|94
19|13
19|82
19|14
19|73
19|33
19|69
19|76
19|27
19|15
19|72
19|45
19|55
19|66
19|81
19|92
19|54
19|68
19|93
19|53
19|11
19|36
19|71
19|84
97|29
97|78
97|64
97|53
97|63
97|43
97|52
97|91
97|18
97|22
97|16
97|14
97|79
97|32
97|75
97|88
97|59
97|36
97|82
97|96
97|72
97|19
97|56
97|41
75|71
75|55
75|69
75|15
75|33
75|82
75|84
75|93
75|92
75|73
75|19
75|78
75|94
75|54
75|36
75|81
75|27
75|68
75|14
75|13
75|72
75|53
75|66
75|11
22|91
22|75
22|88
22|56
22|72
22|14
22|19
22|13
22|92
22|52
22|68
22|27
22|73
22|41
22|93
22|36
22|78
22|94
22|82
22|29
22|84
22|54
22|53
22|18
91|68
91|81
91|75
91|71
91|82
91|92
91|33
91|27
91|73
91|56
91|36
91|19
91|13
91|54
91|93
91|18
91|94
91|14
91|84
91|72
91|69
91|53
91|78
91|29
92|97
92|76
92|21
92|13
92|45
92|69
92|81
92|54
92|42
92|68
92|95
92|32
92|11
92|15
92|93
92|33
92|66
92|27
92|71
92|55
92|73
92|65
92|94
92|85
66|43
66|22
66|88
66|79
66|55
66|21
66|41
66|63
66|95
66|64
66|11
66|85
66|97
66|59
66|91
66|45
66|65
66|42
66|76
66|16
66|96
66|52
66|32
66|15
65|79
65|41
65|19
65|18
65|85
65|95
65|22
65|91
65|56
65|43
65|88
65|64
65|63
65|75
65|52
65|16
65|59
65|78
65|97
65|21
65|96
65|29
65|32
65|42
88|93
88|19
88|73
88|36
88|27
88|81
88|69
88|53
88|92
88|54
88|18
88|68
88|84
88|91
88|13
88|75
88|78
88|29
88|82
88|56
88|72
88|94
88|71
88|14
84|92
84|95
84|85
84|13
84|73
84|65
84|33
84|66
84|45
84|42
84|76
84|11
84|68
84|97
84|94
84|21
84|71
84|15
84|27
84|55
84|54
84|81
84|69
84|93
94|81
94|93
94|13
94|32
94|79
94|85
94|21
94|69
94|15
94|71
94|11
94|68
94|33
94|55
94|65
94|76
94|95
94|64
94|54
94|27
94|97
94|66
94|45
94|42
18|69
18|29
18|81
18|72
18|92
18|73
18|93
18|75
18|53
18|54
18|56
18|78
18|71
18|82
18|66
18|36
18|68
18|84
18|27
18|14
18|33
18|13
18|94
18|19
81|11
81|45
81|63
81|95
81|22
81|66
81|15
81|96
81|43
81|59
81|41
81|32
81|33
81|64
81|85
81|42
81|79
81|97
81|21
81|16
81|55
81|76
81|65
81|71
93|45
93|96
93|21
93|27
93|33
93|64
93|85
93|11
93|15
93|43
93|59
93|79
93|97
93|32
93|63
93|76
93|42
93|95
93|55
93|71
93|81
93|65
93|69
93|66
82|92
82|81
82|94
82|93
82|73
82|66
82|21
82|45
82|27
82|13
82|69
82|76
82|95
82|15
82|71
82|54
82|11
82|84
82|68
82|42
82|55
82|85
82|65
82|33
71|15
71|76
71|32
71|21
71|79
71|64
71|97
71|22
71|11
71|33
71|85
71|16
71|96
71|42
71|52
71|43
71|95
71|41
71|59
71|66
71|63
71|65
71|55
71|45
41|88
41|92
41|36
41|53
41|69
41|19
41|91
41|27
41|78
41|93
41|84
41|73
41|29
41|13
41|14
41|54
41|82
41|72
41|94
41|52
41|56
41|18
41|68
41|75
63|43
63|59
63|14
63|22
63|88
63|73
63|96
63|56
63|75
63|82
63|52
63|18
63|16
63|91
63|19
63|36
63|94
63|72
63|84
63|53
63|78
63|41
63|29
63|92
33|96
33|85
33|41
33|65
33|66
33|22
33|95
33|64
33|32
33|52
33|45
33|16
33|55
33|42
33|21
33|79
33|97
33|11
33|59
33|76
33|15
33|43
33|63
33|88
43|14
43|72
43|41
43|82
43|78
43|53
43|56
43|52
43|91
43|16
43|96
43|75
43|18
43|22
43|92
43|88
43|68
43|73
43|59
43|94
43|84
43|29
43|19
43|36
96|88
96|78
96|94
96|84
96|75
96|68
96|53
96|91
96|52
96|56
96|16
96|19
96|59
96|22
96|73
96|14
96|82
96|29
96|36
96|54
96|72
96|92
96|41
96|18
45|63
45|59
45|96
45|29
45|88
45|95
45|16
45|32
45|64
45|78
45|21
45|18
45|22
45|97
45|43
45|41
45|85
45|75
45|79
45|42
45|91
45|56
45|65
45|52
73|11
73|71
73|32
73|13
73|68
73|69
73|97
73|55
73|21
73|81
73|42
73|54
73|85
73|15
73|65
73|45
73|95
73|94
73|64
73|76
73|93
73|27
73|66
73|33
69|32
69|55
69|11
69|66
69|45
69|16
69|65
69|42
69|95
69|96
69|76
69|71
69|59
69|21
69|15
69|63
69|85
69|22
69|43
69|97
69|33
69|64
69|79
69|81
76|52
76|64
76|18
76|91
76|16
76|41
76|21
76|85
76|32
76|59
76|56
76|75
76|42
76|45
76|88
76|97
76|29
76|96
76|79
76|43
76|65
76|95
76|63
76|22
11|29
11|96
11|45
11|43
11|65
11|22
11|76
11|21
11|59
11|56
11|97
11|91
11|85
11|88
11|64
11|52
11|95
11|16
11|32
11|79
11|18
11|63
11|41
53|27
53|15
53|33
53|14
53|92
53|54
53|82
53|55
53|84
53|68
53|94
53|66
53|11
53|69
53|71
53|76
53|72
53|93
53|13
53|73
53|95
53|65
21|63
21|91
21|41
21|53
21|19
21|85
21|43
21|52
21|36
21|16
21|18
21|75
21|64
21|29
21|59
21|79
21|32
21|56
21|96
21|78
21|14
29|55
29|33
29|53
29|71
29|19
29|36
29|94
29|82
29|92
29|54
29|72
29|84
29|13
29|75
29|15
29|14
29|73
29|93
29|68
29|69
64|59
64|79
64|75
64|53
64|88
64|91
64|56
64|14
64|36
64|78
64|41
64|16
64|84
64|18
64|22
64|96
64|29
64|19
64|43
56|54
56|19
56|68
56|72
56|69
56|33
56|94
56|66
56|92
56|13
56|82
56|71
56|93
56|53
56|14
56|81
56|75
56|27
59|68
59|84
59|36
59|54
59|82
59|52
59|53
59|78
59|22
59|91
59|72
59|94
59|56
59|29
59|41
59|92
59|73
42|85
42|21
42|22
42|63
42|97
42|78
42|75
42|36
42|43
42|96
42|32
42|18
42|79
42|91
42|19
42|64
13|32
13|65
13|55
13|69
13|96
13|93
13|63
13|95
13|81
13|71
13|33
13|76
13|85
13|15
13|64
16|22
16|56
16|73
16|19
16|14
16|36
16|53
16|29
16|93
16|52
16|72
16|94
16|92
16|91
79|88
79|22
79|19
79|96
79|56
79|16
79|41
79|43
79|84
79|29
79|14
79|59
79|92
68|63
68|65
68|64
68|93
68|79
68|81
68|55
68|97
68|33
68|15
68|13
68|85
72|95
72|84
72|55
72|93
72|42
72|33
72|69
72|82
72|27
72|45
72|94
78|73
78|76
78|72
78|68
78|11
78|54
78|84
78|15
78|55
78|19
52|36
52|69
52|81
52|82
52|56
52|88
52|92
52|13
52|53
54|43
54|45
54|21
54|32
54|13
54|93
54|15
54|81
95|19
95|36
95|22
95|56
95|21
95|18
95|52
55|88
55|65
55|21
55|32
55|15
55|11
85|36
85|18
85|64
85|72
85|88
14|33
14|72
14|92
14|55
32|16
32|18
32|88
27|32
27|95
36|68

32,64,63,43,59,16,52,88,91,29,75,19,36,53,14,72,82
56,29,22,85,64,63,43,45,65,41,96,42,75
52,41,14,84,72,78,73,36,68,88,94,91,16,19,13,92,53
85,32,79,52,91,78,14
21,59,43,81,16,45,55,64,11,85,33,42,32,15,22
21,22,41,42,95,45,91,97,96
45,95,21,32,79,43,96,59,16,41,91,18,56,29,75
29,54,88,81,92,27,82,18,69,19,94,68,78,91,84,93,13
22,56,92,52,91,18,19
79,96,88,18,92,19,78,14,59,84,53,72,43,22,56,63,75,82,29,91,41
95,42,21,97,32,64,79,63,43,96,59,16,22,41,88,91,18,56,29,75,19
59,52,88,56,75,14,82,94,54
32,45,11,52,22,85,96,76,41,79,21,88,91,55,63,43,64
66,55,15,11,76,45,42,85,97,32,64,63,96,59,16,22,52
76,45,21,97,79,59,16,22,88,18,56
66,19,94,11,27,33,54,78,36
11,63,81,43,22,96,85,33,16
29,96,43,53,97,85,78,16,14,79,18,63,75,19,22
41,52,88,91,29,75,72,84,73,94,54,13,27
69,84,33,54,13,18,73,81,75,14,93,94,82,36,56
32,64,22,43,96,55,42,15,65,11,71,97,76
56,29,75,78,36,53,14,72,82,84,92,73,94,68,54,13,27,69,81,71,66
65,85,32,91,29,75,78
13,93,69,81,71,66,55,15,76,45,95,85,32,63,43
66,96,79,59,16,11,97,69,33
95,11,64,16,66,76,55,88,15,97,65,41,96,42,21,43,52,79,22
52,88,91,29,78,36,14,84,73,94,54,27,69
97,32,64,79,63,43,96,59,16,22,41,52,88,56,29,75,78,14,72
13,81,54,76,15,85,33,55,97,71,92,45,95,11,65,27,42,73,93,68,21,69,94
91,29,78,19,36,53,14,73,94,54,27,81,71
45,95,63,88,56,96,42,75,85
96,88,78,53,72,82,94
72,75,82,59,36,56,16,18,78,41,52,22,29,92,94,68,73
91,18,56,29,75,19,36,14,72,82,84,92,94,54,13,93,69,81,71
73,94,54,13,93,27,69,71,33,66,11,76,65,95,42,21,85,97,32
84,92,81,33,66,76,45,95,85
27,33,15,11,76,45,65,95,32,63,59
78,88,96,14,41,72,64,36,84
82,92,73,93,69,81,66,55,15,45,65,42,21
68,54,69,81,33,66,95,85,79
91,22,59,82,84,29,18,56,96,14,94,53,43,75,73,52,88
27,94,93,53,56,75,78,84,72,41,82
82,65,45,54,15,53,71,13,55,68,66
54,13,93,27,69,81,71,33,66,55,15,11,76,45,95,42,21,85,97,32,64,79,63
93,76,97,69,15,92,73
64,79,96,18,56,29,75,78,19,53,72,82,84
84,92,73,94,68,54,13,93,27,69,81,71,33,66,15,11,76,45,65,95,42,21,85
36,22,52,16,78
14,72,82,84,92,73,94,68,54,13,93,69,81,71,33,66,55,15,11,76,45,65,95
56,92,54,84,27,73,13,93,19
33,84,11,14,92,72,71,95,94
85,32,55,76,33,59,79,66,95,11,63,21,96
27,75,71,92,72,68,36,93,69,53,14,19,81,82,54,56,18,29,33,13,94,78,84
69,94,13,85,97,95,93,81,64
71,21,63,96,81,22,85,95,76,97,59
65,63,96,76,42,95,71,16,55,11,21
92,41,94,56,68,84,22,19,91,88,53,14,54,73,72,75,13,18,36
36,53,14,72,82,84,92,73,94,68,54,13,93,27,69,81,71,33,66,55,15,11,76
65,81,13,33,11,76,93,42,45,73,15,55,95,84,92,85,71,21,54,66,27
59,16,22,41,88,91,56,29,75,78,19,36,14,82,84,92,73,94,54
94,27,42,33,84,72,81,93,82,71,65
66,21,15,33,32,27,55,54,95,69,76,71,73,65,42,85,81,45,97,13,68
53,27,93,19,82,33,81,69,36,54,94,71,72,66,73,76,15,14,13
29,75,19,36,53,14,82,84,92,73,94,68,54,13,93,27,69,71,33,66,55
14,88,82,36,78,91,63,43,22
22,91,18,56,29,14,92,73,93
85,59,41,88,18
63,43,59,16,41,88,56,29,75,19,14,82,84,92,73
97,32,64,79,63,43,96,16,22,41,52,91,29,78,19,36,53,14,72
95,33,65,13,72,76,92,14,55
64,65,52,78,91,97,96
71,78,84,56,27,93,36,72,94
69,66,93,72,55,15,92,13,45,68,11,27,73,54,76,95,84,94,71,42,33,65,82
36,72,92,73,94,68,27,69,81,33,66
22,41,52,18,29,75,78,53,14,72,82,84,92,94,68,54,93
43,96,16,41,52,88,91,18,29,78,19,36,53,14,72,82,84,92,73
97,21,27,15,76,96,95,42,45,11,81,32,79,33,69,59,63,85,43,65,64,66,71
54,81,21,93,68,85,97,73,76,55,11,42,95,69,33,66,71,45,65,15,92
32,42,64,15,18,45,79
15,66,84,54,45,93,95,33,69,65,55,82,27,71,68
73,53,27,56,36,14,69,66,54,68,92,75,29,94,93,13,78,84,72,33,19,82,81
15,65,27,32,69,45,73,71,85
64,22,91,36,72
66,55,11,76,45,65,95,42,21,85,97,64,79,43,96,22,41,52,88
66,68,69,79,45,55,11
75,78,19,36,82,84,13,81,71
71,55,65,95,85,97,32,64,79,96,59,22,41
53,14,72,82,84,92,73,94,13,93,69,81,33,66,55,15,11
72,68,27,94,14,71,91,56,81,78,73,82,18
15,69,96,93,95,21,33,55,42,97,63,85,11
64,71,45,27,97,94,93,15,65,55,68,42,54,81,66,69,21
78,36,14,72,82,92,73,94,68,54,13,93,69,66,55,15,11
68,84,78,56,27,75,13,69,82,18,14,93,81,54,71
76,45,65,21,85,97,64,79,63,43,59,16,22,41,52,88,18,56,29
97,88,52,43,36,18,96,29,16,41,64,59,75,56,63,19,72
78,53,14,72,82,84,73,68,54,13,27,66,55,15,11
96,16,22,52,88,18,56,29,75,78,19,36,53,72,82,84,92,73,68
88,56,59,63,29,14,43,32,97,53,96,52,91
63,95,85,18,16,78,22,32,91,97,21,88,41,43,29,56,64,52,19
14,72,82,94,54,13,93,27,69,33,66,55,15,76,45,65,95
96,29,75,41,18,73,94,68,56,36,59,52,16,91,53,88,92,82,84,22,72,14,78
95,32,79,91,18,29,19
95,42,21,85,97,32,64,79,96,16,41,52,91,29,75,78,19
11,93,94,68,81,71,69
96,92,75,82,56,22,91,14,88,29,41,94,19
66,55,15,11,45,65,95,42,21,85,97,32,64,79,43,96,59,16,22,41,88
66,15,95,42,21,85,32,64,63,96,59,16,22,41,52
22,52,55,59,41,45,33,64,16,76,96,43,79,11,95,32,63,65,85
41,19,18,95,96,16,52,85,88
59,16,41,32,63,64,21,55,97,42,95,91,15,79,65
63,16,96,97,95,91,88,42,21,85,15,18,64,32,22,79,76,11,65,59,45
93,21,66,69,32,15,97,55,64,45,54,79,27,33,71
14,72,82,84,92,94,54,13,93,27,69,81,71,66,55,15,11,45,65
66,55,81,71,69,84,36,29,27,13,82,33,14,73,68
27,29,81,68,36,92,78,53,54,71,14,66,93,72,19,55,13
32,91,53,18,96,56,64,59,21,43,78,19,63,36,79,22,88,16,85
16,75,22,96,78,41,52,53,91,84,64
81,68,78,88,73,82,56
92,73,94,68,54,13,93,27,69,81,71,33,11,45,95,42,21,85,97
73,85,11,27,54,95,65,42,93,32,81,33,66
13,93,55,15,64,63,43
72,82,84,92,73,94,68,54,13,93,27,69,81,71,33,66,15,11,76,45,65,95,42
54,13,93,27,69,81,71,66,55,15,11,76,45,42,21,85,97,32,64,79,63
27,53,19,41,75,88,56,54,92
66,27,15,92,84,94,55,11,81,95,42,73,65,45,76,21,71,85,54
43,14,52,41,36,88,92,18,82,72,96,94,53
85,97,64,43,16,22,52,78,14
75,36,53,72,13,33,15
59,52,42,19,64,88,36
78,97,29,36,18,53,91,16,14,79,43,19,85,63,59,22,75,88,64,52,96
53,73,93,71,55,76,65
93,69,81,71,15,45,21,85,97,63,96
56,92,14,88,93,73,84,52,72,36,82,27,78,19,18,69,75,68,53,91,29,94,54
81,84,92,15,68,27,42,95,13,11,69,66,76,33,72,55,71,45,82
71,66,15,45,65,95,42,21,85,97,32,64,43,22,41
19,73,54,27,81,71,76
92,68,82,36,18,91,93,41,19,75,27,84,53
82,84,92,73,94,54,13,93,27,81,33,66,55,15,11,76,45,65,21
43,41,16,96,14,29,64,22,78,36,18,88,56,53,72,52,59,75,82
72,82,84,92,73,94,68,54,13,93,27,69,81,71,33,66,55,15,11,76,45,65,42
43,59,16,41,36,84,94
13,93,69,81,71,33,66,55,15,11,76,45,65,95,42,21,85,64,79,63,43
16,52,18,29,78,14,82,92,73,54,13
97,64,43,41,29,14,72
18,29,75,78,19,36,53,14,72,82,84,92,73,68,54,13,27,69,33
71,42,65,63,97,76,54
55,43,45,16,85,79,65,11,64,59,42,63,97,33,96,95,41,22,66,15,76,71,32
75,19,53,14,73,54,27,69,81,33,66,55,15
11,76,45,65,85,97,64,79,63,43,96,16,22,52,88,91,56
88,52,29,42,59,56,36,22,97,91,41,19,85,79,21,96,32,18,78,16,75
65,95,42,21,85,32,64,79,63,43,96,59,16,41,52,88,91,18,56,29,75
71,33,66,55,15,11,76,45,65,95,42,21,85,97,32,79,63,43,96,59,16,22,41
21,85,16,41,52,91,18,56,29,75,53
56,45,85,43,75,41,21,22,59,52,63,42,32,29,64
85,95,75,91,52,96,88
33,97,66,32,13,76,65,42,94,81,64,21,11,95,93,55,45
88,91,18,56,29,75,78,19,36,53,14,72,82,84,92,94,68,54,13,93,27,69,81
22,16,65,59,95,33,66,81,63,64,76,42,97,43,15
81,15,69,82,65,84,14,92,33,13,45,68,72,55,93,94,11,71,95
27,68,91,56,19,13,93,69,92,73,81,18,78,82,29,88,72,53,36,14,75
78,36,85,59,16,97,52,42,64
79,63,96,59,16,22,41,52,91,18,56,75,78,19,36,14,72,82,92
15,69,32,43,13,66,93,45,79
97,64,79,63,43,59,16,41,52,88,91,18,56,29,75,78,19,36,53,14,72
29,92,68,84,52,75,91,56,19,22,53,88,72,36,18,82,41,73,14
84,59,22,18,16,64,91,53,88,63,29,72,19
27,56,72,29,92,81,53,69,73,36,94,54,68,82,78,33,71,18,13
68,92,53,91,36,29,18,78,72,84,73,94,13,93,81,19,27,88,54
21,13,68,94,33,45,11,54,71,66,69,55,73,65,81
93,29,13,19,92,36,91,52,88,78,56,73,27,84,69
56,75,72,82,73,81,66
85,73,68,21,54,76,95,55,45,94,32
66,45,65,95,42,97,64,43,22,41,52
63,32,43,59,85,41,95,42,88,55,96,22,97,91,65,76,11,21,16,15,64,45,52
45,43,11,66,55,64,63,93,95,69,81,13,21,79,15,97,27
64,32,88,79,41,22,18,75,56,96,91,21,45,29,59,52,85,63,95
69,81,71,33,15,11,76,95,42,85,97,64,79,43,96,59,16
15,68,13,66,71,93,11,94,19,92,36,69,27,82,81
43,71,96,41,85,97,76,63,66
95,97,64,96,43,79,93,85,69,66,32
22,41,52,88,91,18,56,29,75,78,19,36,53,14,82,84,92,73,94,68,54,13,93
82,76,72,14,71,33,19,36,93,13,73,92,94,53,84,55,11,81,54,69,66,15,27
72,32,19,22,56,59,36,16,91,96,82,88,29
79,65,95,85,11,52,56,42,21,91,16
16,22,56,29,78,19,36,53,84,92,73,94,68,54,13
96,84,19,53,94,88,68,72,36,52,59,92,22,56,78,14,16,41,75
22,52,91,18,19,14,68,54,93";

var smallInput =
@"47|53
97|13
97|61
97|47
75|29
61|13
75|53
29|13
97|29
53|29
61|53
97|53
61|29
47|13
75|47
97|75
47|61
75|61
47|29
75|13
53|13

75,47,61,53,29
97,61,53,29,13
75,29,13
75,97,47,61,53
61,13,29
97,13,75,29,47";

var smallest = "";

var input = smallInput;
input = fullInput;
//input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0L;

var lines = input.Split(Environment.NewLine);
var rules = lines.Where(x => x.Contains('|')).Select(x => x.Split('|').Select(int.Parse)).ToList();
var pagesToProduceCollection = lines.Where(x => x.Contains(',')).Select(x => x.Split(',').Select(int.Parse)).ToList();
var invalids = pagesToProduceCollection.Where(x => !IsValidOrder(x));

foreach (var invalid in invalids)
{
    var reordered = invalid.OrderBy(x => x, new ElfComparer(rules));
    var middleIndex = reordered.Count() / 2;
    result += reordered.ElementAt(middleIndex);
}

bool IsValidOrder(IEnumerable<int> enumerable)
{
    for (int i = 0; i < enumerable.Count(); i++)
    {
        var x = enumerable.ElementAt(i);
        foreach (var rule in rules.Where(r => r.ElementAt(0) == x))
        {
            var y = rule.ElementAt(1);
            if (enumerable.Take(i).Contains(y))
            {
                return false;
            }
        }
    }
    return true;
}

timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();

class ElfComparer(IEnumerable<IEnumerable<int>> rules) : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (rules.Any(r => r.ElementAt(0) == x && r.ElementAt(1) == y))
        {
            return -1;
        }
        if (rules.Any(r => r.ElementAt(1) == x && r.ElementAt(0) == y))
        {
            return 1;
        }
        return 0;
    }
}