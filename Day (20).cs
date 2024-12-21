﻿//using AoC2023;
//using AoC2024;
//using System.ComponentModel;
//using System.Reflection.Metadata.Ecma335;

//var fullInput =
//@"#############################################################################################################################################
//#.......#...#.......#...#...###.....#.....#.....#.....#.....#...###...###.............#...#...#.......#...#...#...#...#...#.........#...#...#
//#.#####.#.#.#.#####.#.#.#.#.###.###.#.###.#.###.#.###.#.###.#.#.###.#.###.###########.#.#.#.#.#.#####.#.#.#.#.#.#.#.#.#.#.#.#######.#.#.#.#.#
//#.....#.#.#.#.....#...#...#...#...#.#...#.#...#.#.#...#...#.#.#.#...#...#.......#.....#.#.#.#.#...#...#.#.#.#.#.#...#...#...#.....#...#...#.#
//#####.#.#.#.#####.###########.###.#.###.#.###.#.#.#.#####.#.#.#.#.#####.#######.#.#####.#.#.#.###.#.###.#.#.#.#.#############.###.#########.#
//#.....#.#.#.#.....#...#...#...#...#.....#...#.#.#.#.#...#.#.#.#.#.#...#.....#...#.#...#.#...#.###.#.#...#...#.#.#.............###.....#...#.#
//#.#####.#.#.#.#####.#.#.#.#.###.###########.#.#.#.#.#.#.#.#.#.#.#.#.#.#####.#.###.#.#.#.#####.###.#.#.#######.#.#.###################.#.#.#.#
//#.....#...#.#.......#.#.#...###.........#...#.#...#.#.#.#.#.#.#.#...#.....#.#...#...#.#.#.....#...#...#.......#.#.......###...#.....#...#...#
//#####.#####.#########.#.###############.#.###.#####.#.#.#.#.#.#.#########.#.###.#####.#.#.#####.#######.#######.#######.###.#.#.###.#########
//#.....#...#.....#...#.#...#...#.........#.#...#...#.#.#...#...#...#.......#...#...#...#.#.....#.#.....#.....###.#.......#...#...#...###...###
//#.#####.#.#####.#.#.#.###.#.#.#.#########.#.###.#.#.#.###########.#.#########.###.#.###.#####.#.#.###.#####.###.#.#######.#######.#####.#.###
//#.......#.....#...#...#...#.#.#.........#.#.#...#...#...#.........#.#.......#.....#.#...#.....#...###.....#...#.#.#.......#...#...#...#.#...#
//#############.#########.###.#.#########.#.#.#.#########.#.#########.#.#####.#######.#.###.###############.###.#.#.#.#######.#.#.###.#.#.###.#
//###...###...#.........#...#.#...#.....#.#...#.###...#...#.........#...#...#...#.....#...#.#.......#...#...#...#.#...#...#...#...###.#.#.#...#
//###.#.###.#.#########.###.#.###.#.###.#.#####.###.#.#.###########.#####.#.###.#.#######.#.#.#####.#.#.#.###.###.#####.#.#.#########.#.#.#.###
//#...#.#...#.........#.#...#...#.#...#...#...#.....#.#.....#.......###...#.....#.....###.#.#.#...#.#.#.#...#.#...#.....#...#.....#...#...#...#
//#.###.#.###########.#.#.#####.#.###.#####.#.#######.#####.#.#########.#############.###.#.#.#.#.#.#.#.###.#.#.###.#########.###.#.#########.#
//#...#...#.........#...#.......#...#...#...#...#.....#...#.#.....#...#.........#.....#...#.#.#.#...#.#.#...#...#...#...#...#...#.#.#.........#
//###.#####.#######.###############.###.#.#####.#.#####.#.#.#####.#.#.#########.#.#####.###.#.#.#####.#.#.#######.###.#.#.#.###.#.#.#.#########
//#...#...#.#.......#...........#...#...#.#.....#.....#.#.#.#.....#.#.#...#.....#...#...#...#.#...###.#.#.#.....#.....#...#...#.#...#.......###
//#.###.#.#.#.#######.#########.#.###.###.#.#########.#.#.#.#.#####.#.#.#.#.#######.#.###.###.###.###.#.#.#.###.#############.#.###########.###
//#.....#...#.........#.....###.#...#.....#.......#...#.#...#.#...#.#.#.#.#.......#.#...#.###.#...#...#.#.#...#.............#...#...#.....#...#
//#####################.###.###.###.#############.#.###.#####.#.#.#.#.#.#.#######.#.###.#.###.#.###.###.#.###.#############.#####.#.#.###.###.#
//#.......#...#...#...#...#.#...#...#...###.......#.###...#...#.#.#.#.#.#...#...#.#.#...#...#.#.#...#...#.#...#...........#.#...#.#.#...#...#.#
//#.#####.#.#.#.#.#.#.###.#.#.###.###.#.###.#######.#####.#.###.#.#.#.#.###.#.#.#.#.#.#####.#.#.#.###.###.#.###.#########.#.#.#.#.#.###.###.#.#
//#.....#...#.#.#...#.....#.#.#...###.#...#.......#.#.....#.....#...#.#...#.#.#.#.#.#.#.....#.#.#...#.#...#.....#.........#...#...#.#...###...#
//#####.#####.#.###########.#.#.#####.###.#######.#.#.###############.###.#.#.#.#.#.#.#.#####.#.###.#.#.#########.#################.#.#########
//#...#.....#.#.......#...#...#.....#...#...#...#.#.#.......#.........#...#.#.#...#.#.#...###.#...#.#.#...#.......###...#.........#...###.....#
//#.#.#####.#.#######.#.#.#########.###.###.#.#.#.#.#######.#.#########.###.#.#####.#.###.###.###.#.#.###.#.#########.#.#.#######.#######.###.#
//#.#.......#.......#...#...#...#...###...#.#.#.#.#.#...###.#...#...###.#...#.#...#...#...#...#...#.#.....#.#...#.....#...#.....#.###...#...#.#
//#.###############.#######.#.#.#.#######.#.#.#.#.#.#.#.###.###.#.#.###.#.###.#.#.#####.###.###.###.#######.#.#.#.#########.###.#.###.#.###.#.#
//#...............#.###...#...#.#.....#...#.#.#...#.#.#...#.#...#.#.#...#...#...#.....#...#...#.#...#.......#.#...#...#...#...#...#...#.#...#.#
//###############.#.###.#.#####.#####.#.###.#.#####.#.###.#.#.###.#.#.#####.#########.###.###.#.#.###.#######.#####.#.#.#.###.#####.###.#.###.#
//###...###...#...#.....#...#...#.....#...#.#...#...#.#...#.#.###.#.#...#...#...#...#.#...###.#.#...#.###...#.#.....#...#.....#...#.#...#...#.#
//###.#.###.#.#.###########.#.###.#######.#.###.#.###.#.###.#.###.#.###.#.###.#.#.#.#.#.#####.#.###.#.###.#.#.#.###############.#.#.#.#####.#.#
//#...#.#...#...#...#.....#.#...#...#...#.#...#.#...#.#.#...#.#...#...#.#...#.#.#.#.#.#...#...#...#.#.#...#...#.###...#...#...#.#.#.#.......#.#
//#.###.#.#######.#.#.###.#.###.###.#.#.#.###.#.###.#.#.#.###.#.#####.#.###.#.#.#.#.#.###.#.#####.#.#.#.#######.###.#.#.#.#.#.#.#.#.#########.#
//#...#.#.........#...#...#...#...#...#.#.#...#...#.#.#.#.#...#.#...#.#.###...#.#.#...#...#.#...#...#...###...#.#...#...#...#.#.#.#.#.......#.#
//###.#.###############.#####.###.#####.#.#.#####.#.#.#.#.#.###.#.#.#.#.#######.#.#####.###.#.#.###########.#.#.#.###########.#.#.#.#.#####.#.#
//#...#...........#.....#...#.....#...#...#.#...#.#.#.#.#.#...#...#.#...#.......#.....#...#...#.#...........#...#.#...........#.#...#.....#.#.#
//#.#############.#.#####.#.#######.#.#####.#.#.#.#.#.#.#.###.#####.#####.###########.###.#####.#.###############.#.###########.#########.#.#.#
//#.............#.#.....#.#.........#.....#.#.#.#.#.#.#.#...#...#...#.....#.....#.....###...#...#.#.........#...#.#.......#.....#.........#...#
//#############.#.#####.#.###############.#.#.#.#.#.#.#.###.###.#.###.#####.###.#.#########.#.###.#.#######.#.#.#.#######.#.#####.#############
//###...#...#...#...###...#...............#.#.#.#.#.#.#.#...#...#...#.#...#...#.#.....#.....#...#.#.#.....#...#...#.......#.#...#.........#...#
//###.#.#.#.#.#####.#######.###############.#.#.#.#.#.#.#.###.#####.#.#.#.###.#.#####.#.#######.#.#.#.###.#########.#######.#.#.#########.#.#.#
//#...#...#...#.....#.......#.....#.......#...#...#...#.#.###.....#.#.#.#.#...#.#.....#.#.....#.#...#...#.........#...###...#.#.#...#...#...#.#
//#.###########.#####.#######.###.#.#####.#############.#.#######.#.#.#.#.#.###.#.#####.#.###.#.#######.#########.###.###.###.#.#.#.#.#.#####.#
//#.........#...#...#.........###...#...#.........#.....#...#...#.#.#...#...###.#.#.....#...#.#.....#...#.......#...#.....#...#...#...#.......#
//#########.#.###.#.#################.#.#########.#.#######.#.#.#.#.###########.#.#.#######.#.#####.#.###.#####.###.#######.###################
//#...#.....#.....#.....#...#...#.....#.........#.#.....#...#.#...#...........#...#.......#.#.......#...#.#.....###.........###...#.....#.....#
//#.#.#.###############.#.#.#.#.#.#############.#.#####.#.###.###############.###########.#.###########.#.#.###################.#.#.###.#.###.#
//#.#.#...#.....#.....#.#.#.#.#...#...#...#...#...#...#...###.......#.....#...#...........#.#.........#...#...........#...#...#.#.#.#...#.#...#
//#.#.###.#.###.#.###.#.#.#.#.#####.#.#.#.#.#.#####.#.#############.#.###.#.###.###########.#.#######.###############.#.#.#.#.#.#.#.#.###.#.###
//#.#.....#.#...#...#.#...#...#...#.#...#...#.......#...#...........#.###...###.......#.....#.......#...........#...#...#...#...#...#.....#...#
//#.#######.#.#####.#.#########.#.#.###################.#.###########.###############.#.###########.###########.#.#.#########################.#
//#.#...#...#.......#.....#.....#...#...#...#.......#...#...#.......#.............#...#.#...........#...#...###...#.#...#...#...#...#...#...#.#
//#.#.#.#.###############.#.#########.#.#.#.#.#####.#.#####.#.#####.#############.#.###.#.###########.#.#.#.#######.#.#.#.#.#.#.#.#.#.#.#.#.#.#
//#...#.#.###...#...#.....#...#.......#...#.#.#...#...#...#...#.....#...#...#.....#.#...#.#...#.......#.#.#.......#.#.#...#.#.#...#.#.#.#.#.#.#
//#####.#.###.#.#.#.#.#######.#.###########.#.#.#.#####.#.#####.#####.#.#.#.#.#####.#.###.#.#.#.#######.#.#######.#.#.#####.#.#####.#.#.#.#.#.#
//###...#...#.#...#...#.......#...........#.#...#.......#.#.....#...#.#.#.#.#.#.....#.###...#...###...#...#...#...#.#...#...#...###...#.#.#...#
//###.#####.#.#########.#################.#.#############.#.#####.#.#.#.#.#.#.#.#####.#############.#.#####.#.#.###.###.#.#####.#######.#.#####
//#...#...#.#.....#...#.###...###...#...#.#.#...#.........#.#...#.#...#.#.#.#.#.#...#.#.........#...#.......#...###.....#.....#.......#.#.....#
//#.###.#.#.#####.#.#.#.###.#.###.#.#.#.#.#.#.#.#.#########.#.#.#.#####.#.#.#.#.#.#.#.#.#######.#.###########################.#######.#.#####.#
//#.#...#.#.#...#...#...#...#.....#...#...#...#.#.........#.#.#...#...#.#.#...#...#.#.#.....#...#...........#...............#.#...#...#.#...#.#
//#.#.###.#.#.#.#########.#####################.#########.#.#.#####.#.#.#.#########.#.#####.#.#############.#.#############.#.#.#.#.###.#.#.#.#
//#.#...#...#.#.#.........#...................#...........#.#...#...#.#...#...#...#.#.#.....#.###...........#.#.............#...#...###...#...#
//#.###.#####.#.#.#########.#################.#############.###.#.###.#####.#.#.#.#.#.#.#####.###.###########.#.###############################
//#.#...#.....#.#...........#...#.............###.........#.....#...#.#...#.#.#.#.#...#.....#...#.............#.#.........#...................#
//#.#.###.#####.#############.#.#.###############.#######.#########.#.#.#.#.#.#.#.#########.###.###############.#.#######.#.#################.#
//#...#...#...#.........###...#...#...#...#.......#...#...#.........#...#...#...#.....#...#.#...#...#...#.....#...#.....#...#.................#
//#####.###.#.#########.###.#######.#.#.#.#.#######.#.#.###.#########################.#.#.#.#.###.#.#.#.#.###.#####.###.#####.#################
//#...#.....#.........#.....#.......#...#...#...#...#...#...#.........#.............#...#...#.....#...#.#...#.....#...#.#.....#.....#.........#
//#.#.###############.#######.###############.#.#.#######.###.#######.#.###########.###################.###.#####.###.#.#.#####.###.#.#######.#
//#.#.#...###...#...#.......#.#.....#...#.....#...#.....#.....#######...###.........#...#.....#...#...#...#.....#.....#...#...#...#.#.#.......#
//#.#.#.#.###.#.#.#.#######.#.#.###.#.#.#.#########.###.###################.#########.#.#.###.#.#.#.#.###.#####.###########.#.###.#.#.#.#######
//#.#.#.#.#...#...#.........#.#...#...#...#.........#...###################...#.....#.#.#.###...#.#.#...#.#...#...#...#.....#.....#.#.#.......#
//#.#.#.#.#.#################.###.#########.#########.#######################.#.###.#.#.#.#######.#.###.#.#.#.###.#.#.#.###########.#.#######.#
//#.#...#...#...#.........#...###...........#.........#######################...###...#.#.....###.#.#...#...#...#.#.#...#...#.....#.#.#.....#.#
//#.#########.#.#.#######.#.#################.#########################################.#####.###.#.#.#########.#.#.#####.#.#.###.#.#.#.###.#.#
//#.#...#.....#.#.#.......#...#.........#...#.......#################S..#...#.........#...#...#...#.#.#.....###...#.#.....#.#.#...#...#...#...#
//#.#.#.#.#####.#.#.#########.#.#######.#.#.#######.###################.#.#.#.#######.###.#.###.###.#.#.###.#######.#.#####.#.#.#########.#####
//#.#.#.#.#.....#.#...........#.......#...#.#.....#...#################.#.#.#.....#...###...###.#...#.#...#...#...#.#.....#...#.........#.....#
//#.#.#.#.#.#####.###################.#####.#.###.###.#################.#.#.#####.#.###########.#.###.###.###.#.#.#.#####.#############.#####.#
//#.#.#...#...#...###.......#...###...#...#...###...#.###############...#.#.###...#.#.........#...###.....#...#.#...#...#...###.......#.#...#.#
//#.#.#######.#.#####.#####.#.#.###.###.#.#########.#.###############.###.#.###.###.#.#######.#############.###.#####.#.###.###.#####.#.#.#.#.#
//#.#.#.......#.#...#.....#...#...#...#.#.###...###.#.#########.......#...#...#...#.#.#.......###...........#...#.....#...#.....#.....#...#...#
//#.#.#.#######.#.#.#####.#######.###.#.#.###.#.###.#.#########.#######.#####.###.#.#.#.#########.###########.###.#######.#######.#############
//#...#.........#.#.....#.......#...#...#.....#...#...#######...#...###.....#.#...#.#.#.#.......#...........#...#.#...###.........#...........#
//###############.#####.#######.###.#############.###########.###.#.#######.#.#.###.#.#.#.#####.###########.###.#.#.#.#############.#########.#
//###...#...#...#.....#.#...###...#.#...#.........#E#########...#.#...#...#.#.#...#.#.#.#.#.....###...#...#.....#...#...............#...#.....#
//###.#.#.#.#.#.#####.#.#.#.#####.#.#.#.#.#########.###########.#.###.#.#.#.#.###.#.#.#.#.#.#######.#.#.#.###########################.#.#.#####
//#...#...#...#.......#...#.....#.#...#...###...###.#########...#.#...#.#...#.#...#...#...#.....#...#...#.#.........#...#.....#...#...#...#...#
//#.###########################.#.###########.#.###.#########.###.#.###.#####.#.###############.#.#######.#.#######.#.#.#.###.#.#.#.#######.#.#
//#...................#...#...#.#.....#.......#...#.#########...#.#...#.....#.#.......#...#.....#.......#.#.......#.#.#.#...#...#.#.#.......#.#
//###################.#.#.#.#.#.#####.#.#########.#.###########.#.###.#####.#.#######.#.#.#.###########.#.#######.#.#.#.###.#####.#.#.#######.#
//#.......#...#.......#.#...#.#.......#.#...#.....#...#.........#.#...###...#...#...#.#.#...#...#.......#.........#...#...#.#...#...#...#...#.#
//#.#####.#.#.#.#######.#####.#########.#.#.#.#######.#.#########.#.#####.#####.#.#.#.#.#####.#.#.#######################.#.#.#.#######.#.#.#.#
//#.#...#...#...#...#...#.....#.........#.#...#...#...#.###...###.#.#...#.#.....#.#...#...#...#.#...............#...###...#...#.........#.#.#.#
//#.#.#.#########.#.#.###.#####.#########.#####.#.#.###.###.#.###.#.#.#.#.#.#####.#######.#.###.###############.#.#.###.#################.#.#.#
//#...#...#.....#.#...#...#...#.#.......#.....#.#.#...#.#...#...#.#.#.#.#.#.#...#.....#...#.#...#...#.........#...#...#.....#.............#...#
//#######.#.###.#.#####.###.#.#.#.#####.#####.#.#.###.#.#.#####.#.#.#.#.#.#.#.#.#####.#.###.#.###.#.#.#######.#######.#####.#.#################
//#.....#.#.###...#...#.....#.#.#.....#.......#.#.#...#...#.....#.#.#.#.#.#.#.#.#.....#...#.#...#.#.#.......#.........#...#...###...#.........#
//#.###.#.#.#######.#.#######.#.#####.#########.#.#.#######.#####.#.#.#.#.#.#.#.#.#######.#.###.#.#.#######.###########.#.#######.#.#.#######.#
//#...#...#.#.......#.......#...#.....#...#...#.#.#.......#.#...#.#.#.#.#.#.#.#.#.......#.#.#...#.#.#...###...#.........#.........#...#.......#
//###.#####.#.#############.#####.#####.#.#.#.#.#.#######.#.#.#.#.#.#.#.#.#.#.#.#######.#.#.#.###.#.#.#.#####.#.#######################.#######
//#...#...#.#.........#...#...#...#...#.#.#.#.#.#.#...#...#.#.#.#.#.#.#.#.#.#.#...#...#.#.#.#...#.#.#.#.....#...#...#...#.....#.........###...#
//#.###.#.#.#########.#.#.###.#.###.#.#.#.#.#.#.#.#.#.#.###.#.#.#.#.#.#.#.#.#.###.#.#.#.#.#.###.#.#.#.#####.#####.#.#.#.#.###.#.###########.#.#
//#...#.#.#.###...###...#...#...#...#...#.#.#...#.#.#.#.###.#.#.#.#.#.#.#.#...###.#.#...#...###.#.#...###...#...#.#.#.#.#.###...#...#.......#.#
//###.#.#.#.###.#.#########.#####.#######.#.#####.#.#.#.###.#.#.#.#.#.#.#.#######.#.###########.#.#######.###.#.#.#.#.#.#.#######.#.#.#######.#
//#...#.#.#.#...#.#.........#...#.#.......#...###.#.#.#.#...#.#.#.#...#...###.....#...........#.#.#.......#...#...#...#...#...###.#.#.#...#...#
//#.###.#.#.#.###.#.#########.#.#.#.#########.###.#.#.#.#.###.#.#.###########.###############.#.#.#.#######.###############.#.###.#.#.#.#.#.###
//#.#...#...#...#...#...#...#.#.#.#...#.....#...#...#.#.#...#.#.#.#.....#.....#...#...#...#...#.#.#.#...#...###...#...#...#.#.....#...#.#...###
//#.#.#########.#####.#.#.#.#.#.#.###.#.###.###.#####.#.###.#.#.#.#.###.#.#####.#.#.#.#.#.#.###.#.#.#.#.#.#####.#.#.#.#.#.#.###########.#######
//#.#.#.........#...#.#...#...#.#.#...#...#...#.....#...###...#.#...#...#.#.....#.#.#.#.#.#...#.#.#...#.#.......#...#.#.#.#.#.....#...#.#.....#
//#.#.#.#########.#.#.#########.#.#.#####.###.#####.###########.#####.###.#.#####.#.#.#.#.###.#.#.#####.#############.#.#.#.#.###.#.#.#.#.###.#
//#.#.#.........#.#.#.#.......#...#.....#.#...#...#...#.......#.#...#...#.#.#.....#.#.#.#.#...#...#...#.....#.......#...#...#...#.#.#.#...#...#
//#.#.#########.#.#.#.#.#####.#########.#.#.###.#.###.#.#####.#.#.#.###.#.#.#.#####.#.#.#.#.#######.#.#####.#.#####.###########.#.#.#.#####.###
//#...#...###...#.#.#.#.#...#...........#.#.#...#.#...#.....#...#.#.#...#...#.....#.#.#.#.#.....#...#.#.....#...#...#...#...#...#.#.#.#.....###
//#####.#.###.###.#.#.#.#.#.#############.#.#.###.#.#######.#####.#.#.###########.#.#.#.#.#####.#.###.#.#######.#.###.#.#.#.#.###.#.#.#.#######
//#.....#.....#...#...#...#.........#...#.#.#.###...###.....#...#.#...#...#.......#.#...#.#...#...#...#.#...#...#...#.#.#.#.#.###.#.#.#.......#
//#.###########.###################.#.#.#.#.#.#########.#####.#.#.#####.#.#.#######.#####.#.#.#####.###.#.#.#.#####.#.#.#.#.#.###.#.#.#######.#
//#.....#.....#.....###...###...#...#.#...#.#.#.........#...#.#.#...#...#.#.#.....#.....#...#.....#...#.#.#.#.#.....#.#.#.#.#...#...#...#...#.#
//#####.#.###.#####.###.#.###.#.#.###.#####.#.#.#########.#.#.#.###.#.###.#.#.###.#####.#########.###.#.#.#.#.#.#####.#.#.#.###.#######.#.#.#.#
//#...#...#...#...#.#...#.....#...#...#...#...#.........#.#.#.#...#...#...#.#.#...#...#.......###.....#...#.#.#.....#.#.#.#...#...#...#...#...#
//#.#.#####.###.#.#.#.#############.###.#.#############.#.#.#.###.#####.###.#.#.###.#.#######.#############.#.#####.#.#.#.###.###.#.#.#########
//#.#.....#...#.#...#.#...#...#...#.....#.#.........###.#.#.#...#...#...###...#...#.#...#...#.............#...#...#.#.#...###...#...#...#...###
//#.#####.###.#.#####.#.#.#.#.#.#.#######.#.#######.###.#.#.###.###.#.###########.#.###.#.#.#############.#####.#.#.#.#########.#######.#.#.###
//#.#...#.....#.....#...#.#.#.#.#...#...#.#.#.....#.....#.#.#...###.#.....#.......#...#.#.#.#...#...#...#...#...#...#.###...###.#.....#...#...#
//#.#.#.###########.#####.#.#.#.###.#.#.#.#.#.###.#######.#.#.#####.#####.#.#########.#.#.#.#.#.#.#.#.#.###.#.#######.###.#.###.#.###.#######.#
//#.#.#...#...#...#...###...#.#.###...#...#...#...#.......#.#.....#.#.....#.....#...#.#...#...#.#.#.#.#...#.#...#...#.....#...#.#.#...#.....#.#
//#.#.###.#.#.#.#.###.#######.#.###############.###.#######.#####.#.#.#########.#.#.#.#########.#.#.#.###.#.###.#.#.#########.#.#.#.###.###.#.#
//#.#.#...#.#.#.#...#.....#...#.#...............#...#.......#.....#.#...#.......#.#.#.........#.#.#.#.#...#...#.#.#.#.....#...#.#.#.#...#...#.#
//#.#.#.###.#.#.###.#####.#.###.#.###############.###.#######.#####.###.#.#######.#.#########.#.#.#.#.#.#####.#.#.#.#.###.#.###.#.#.#.###.###.#
//#.#.#...#.#.#...#...#...#.....#...#...#.....#...###...#...#.....#...#.#...#...#.#...#.....#.#.#.#.#.#.#.....#...#.#.###...###.#.#...#...#...#
//#.#.###.#.#.###.###.#.###########.#.#.#.###.#.#######.#.#.#####.###.#.###.#.#.#.###.#.###.#.#.#.#.#.#.#.#########.#.#########.#.#####.###.###
//#...###.#.#.#...###...###.........#.#.#...#.#...#...#.#.#.#.....###.#...#.#.#.#.#...#...#...#.#.#...#.#.#.........#...###...#...#...#...#...#
//#######.#.#.#.###########.#########.#.###.#.###.#.#.#.#.#.#.#######.###.#.#.#.#.#.#####.#####.#.#####.#.#.###########.###.#.#####.#.###.###.#
//#.......#.#.#.#...........#.....#...#.#...#...#...#.#.#.#.#...#.....#...#.#.#.#.#.#...#...#...#.....#.#.#...#...#...#.....#.......#...#.#...#
//#.#######.#.#.#.###########.###.#.###.#.#####.#####.#.#.#.###.#.#####.###.#.#.#.#.#.#.###.#.#######.#.#.###.#.#.#.#.#################.#.#.###
//#.........#...#.............###...###...#####.......#...#.....#.......###...#...#...#.....#.........#...###...#...#...................#...###
//#############################################################################################################################################";

//var smallInput =
//@"###############
//#...#...#.....#
//#.#.#.#.#.###.#
//#S#...#.#.#...#
//#######.#.#.###
//#######.#.#...#
//#######.#.###.#
//###..E#...#...#
//###.#######.###
//#...###...#...#
//#.#####.#.###.#
//#.#...#.#.#...#
//#.#.#.#.#.#.###
//#...#...#...###
//###############";


//var input = smallInput;
//input = fullInput;
////input = smallest;

//var result = 0;
//var timer = System.Diagnostics.Stopwatch.StartNew();

//(char[][] grid, int height, int width) = Utils.Parse2DGrid(input);
//var byIndex = grid.Select((x, i) => x.Select((y, j) => ((x: j, y: i), c: y))).SelectMany(x => x);
//((int startX, int startY) start, char _) = byIndex.Single(x => x.c == 'S');
//((int targetX, int targetY) target, char _) = byIndex.Single(x => x.c == 'E');
//var startDct = GetDistanceFrom(start);
////var targetDct = GetDistanceFrom(target);
//var baseTime = height < 20 ? 84 : 9380;

//Dictionary<(int x, int y), int> GetDistanceFrom((int x, int y) from)
//{
//    var visited = new HashSet<(int x, int y)>();
//    var dct = new Dictionary<(int x, int y), int>();
//    var queue = new PriorityQueue<(int x, int y, int length), int>();
//    queue.Enqueue((from.x, from.y, 0), 0);
//    while (queue.Count > 0)
//    {
//        var item = queue.Dequeue();
//        visited.Add((item.x, item.y));
//        dct.Add((item.x, item.y), item.length);

//        void TryQueue(int newX, int newY)
//        {
//            if (newX < 0 || newY < 0 || newX >= width || newY >= height) { return; }
//            var weight = grid[newY][newX];
//            if (weight == '#') { return; }
//            if (!visited.Contains((newX, newY)))
//            {
//                queue.Enqueue((newX, newY, item.length + 1), item.length + 1);
//            }
//        }

//        foreach (var neighbour in Utils.Directions)
//        {
//            TryQueue(item.x + neighbour.x, item.y + neighbour.y);
//        }
//    }
//    return dct;
//}

//foreach (var from in startDct)
//{
//    var targets = startDct.Where(to => Manhatten(from.Key, to.Key) <= 20 && from.Key != to.Key).Where(to => to.Value - from.Value - Manhatten(from.Key, to.Key) >= 100).ToList();
//    foreach (var item in targets)
//    {
//        //Console.WriteLine(from + "" + item);
//        result++;
//    }
//}



//int Manhatten((int x, int y) from, (int x, int y) to) => Math.Abs(from.x - to.x) + Math.Abs(from.y - to.y);

//Console.WriteLine(result);


//timer.Stop();
//Console.WriteLine(timer.ElapsedMilliseconds + "ms");
//Console.ReadLine();
