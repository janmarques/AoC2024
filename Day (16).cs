﻿//using System.Text;

//var fullInput =
//@"#############################################################################################################################################
//#.......#...#.....#...........#.....#.......#.......#.............#.........#...........#...............#.......#.....#.......#............E#
//###.###.#.#.###.###.#####.###.#.#####.#.#####.###.###.#########.###.#.#####.#.###.###.#.#######.#####.#.#.#.###.###.#.#.#.#.#.#.#.#########.#
//#...............#...#.....#.....#.....#.......#...#...#...#.....#...#...#...#...#.....#...................#.#.#...#.#.................#...#.#
//#.#.#.#.#.#.#####.###.#####.#####.#############.#.#.#####.#.#.###.###.#.#######.#####.#######.#####.#.#.#.#.#.###.#####.#.###.#####.#.#.#.#.#
//#.#...#.#...#.....#.#...#.....#...#.....#.......#.#.....#.#.#.#.....#...#.......#...#...#.#...#...#.#.#...#.#...#.......#...........#.#.#...#
//#.#.#.#.#.#.#.#####.###.#####.#.#####.#.#.#############.#.#.#.#.#####.#.#.#######.###.#.#.#.###.###.#.#####.#.#######.#.#.###.###.#.###.###.#
//#.#...#.#.#.#.....#...#.................#.#...........#.#.#.#.................#...................#.......#.#.#.....#...#.........#.#.....#.#
//#.#.###.###.#####.###.###.#############.#.#.#########.#.#.#.###.#.#.#.#######.#.#.#.#.###.#######.#.#.#####.#.#.###.#.#####.#.#######.###.#.#
//#.#...........#...#.....#.#.......#.....#...#...#...#.....#.#...#.............#.#.#.#.#...#.....#...#.....#.#...............#...#.....#...#.#
//#.#.#####.#####.###.#.###.#.#####.#.#.###.###.#.#.#.#####.#.#.###.###.#.#.###.###.#.#.#.###.###.###.#.###.#.#.###.###.#.#####.#.#.#####.#.#.#
//#.......#.#...........#...#.#...#.#.#.#.......#...#...#...#.....#.......#...#...#.#.#.#.#...#.#...#.#.#...#.#...#.#.....#.....#...#.....#...#
//#.#.###.###.#.###.#.###.###.#.#.#.#.#.#.#####.#######.#####.#####.###.#####.###.#.#.#.#.###.#.###.###.###.#.#.#.#.#.#.###.#########.#########
//#...#.#.#...#...#...#...#...#.#.#...#.#.#.....#...#...#...#.#...#.....#...#...#...#.................#...#...............#...#...............#
//###.#.#.#.###.###.###.###.###.#######.#.#######.#.#.#.#.#.###.#.#####.###.#.#####.#.#.#######.#.###.###.#####.#####.#.#.###.###.###########.#
//#.#.#.#.....#.#...#...#...#...........#.....#...#.#...........#...#.....#.#.......#.#.#...#...#...#.#...#...#.....#...#...#...#.#...#...#...#
//#.#.#.###.###.#.###.###.#######.###.#.#####.#.###.###############.#####.#.#########.#.#.#.#.#####.#.#.#####.#.###.#.#.###.###.###.#.###.#.###
//#.........#...#.........#.....#.#...#.....#.#.#.#.........#.....#...#.....#.....#...#...#.#.#...#...#...#...#.#...#.#.#.#...#.#...#.#...#.#.#
//#.#######.#.#####.#######.###.#.#.#######.#.#.#.#########.#.###.###.#.#####.###.#.#######.#.###.#######.#.#.#.#.#####.#.###.#.#.###.#.###.#.#
//#...#.......#...#.#.......#...#.#.....#...#...#.....#...#.#.#...#...#.#.....#.#.#.....#...#.#.....#.....#.#.#.......#.#.......#.#.#.#.....#.#
//#.###.###.#.#.#.#.#.#######.###.#####.#########.#.#.#.###.#.#.#.#.#####.#####.#.#####.#.###.#.###.#.#####.#.#.#####.#.#######.#.#.#.#####.#.#
//#.#...#.#...#.#.#...#.....#.#.......#.......#.....#...#...#.#.#.#.......#.#.....#.....#...#...#.#...#.....#...#.#...#.#...#.............#...#
//#.#.###.#.###.#.#####.###.#.#######.#######.#.###.#####.#####.###########.#.#####.#####.#.#####.#####.#######.#.#.###.#.#.#####.#.#.#.#.#####
//#.#...#...#.#.#.......#...#.......#.#.....#.....#.....#.....#.........#.....#.....#...#.#.......#.....#.#.....#.#.#...#.#.........#...#.....#
//#.###.#.#.#.#.#####.#############.#.#.###.#####.#####.#####.#.###.#.#.#.###.#.#####.###.#######.#.#.###.#.#.###.#.#.#.#.###################.#
//#.......#...#.#.....#...........#.#.#...#.#...........#.....#...#.#...#.#.....#.....#...#.....#...#.#.....#.....#.#.#...#...#...#...#.....#.#
//#######.#.#.#.#.#.###.#########.#.#.#####.#.#.#######.#.#######.#.#####.#.#####.#.#.#.###.#.#.#####.#.#########.#.#.#.#.#.#.#.###.#.#.###.#.#
//#.......#...#.#.......#.......#...#.......#.....#...#.#.#...#...#.....#.#...#.......#...#.#.#.#...#.#...........#.#.#...#.#.#.#...#...#...#.#
//#.#.###.#.#.#.###########.###.#####.#######.###.#.#.###.#.#.#.#######.#.###.#.#####.###.###.#.###.#.#.#########.#.#.#####.#.#.#.#.#.###.###.#
//#.#.#.....#.#.#.#.........#...#.....#.....#...#...#.#...#.#...#.............#.....#...#...#.#...#.#.#.#.......#.#.#.......#.#.#...#...#.#...#
//#.###.#.#.###.#.#.#.#######.###.#.###.###.#####.#.#.#.###.###.###.#.#####.#.###.#.#.#####.#.###.#.#.#.#.#####.###.#########.#.###.###.#.#.#.#
//#...#.#.#.....#.#.#.....#.#.#...#.#.....#.......#.#.#.#...#...#...#...........#.#.#.#...#...#...#.#.#.#.....#...#.#.............#...#.#...#.#
//#.#.#.#.#######.#.#####.#.#.#.###.#.###.#######.###.#.###.#.###.#####.#######.###.###.#.#####.###.#.###.#######.#.#.###########.###.#.#.#####
//#.#...#.............#.#.#.#.#.....#...#...#.........#...#.#.#.........#.......#...#...#.....#.#...#...#.#...#...#.#.....#...#...............#
//#.#################.#.#.#.#.#####.###.###.#.###########.#.#.#.###.#####.#.#####.###.#####.###.###.###.#.#.#.#.###.#.###.#.#.#.#####.#.#.#.#.#
//#...........#.....#...#.#...#...#...#...#.......#.......#.#.#...#.#.....#.........#.#...#...#.....#.#.#.#.#.#...#.#...#.#.#.#...........#.#.#
//###########.#.###.###.#.#.#####.###.###.###.#####.#######.#.#.#.#.#.#######.#.###.#.#.#.###.#####.#.#.#.#.#.###.#.#.#.###.#.###.#.#######.#.#
//#...#.......#...#...#.#.#.#.......#.#.#...#.#.....#.....#.#.#.....#.#.....#.#.#...#.....#.#.........#.#.#.#.....#...#.#...#...#.#.........#.#
//#.#.#.#####.#.#.###.###.#.#.###.###.#.###.#.#.#####.#.#.#.#.###.#.#.#.###.#.###.###.###.#.###########.#.#.###.#.#####.#.#####.#############.#
//#.#...#...#.#.#.#.#.....#.#...#.#...#...#.#.#.#.....#.#...#.#...#...#...#.#...#.#.....#.#...#.....#...#.#.#...#.....#.#...#...#...#.......#.#
//#######.#.#.#.#.#.#######.#.#.###.###.#.#.###.###.###.#.###.#.#####.###.#####.#.#.#.###.###.#.###.#.###.#.#.#.#######.#.#.#.###.#.#.#####.#.#
//#.....#.#...#.#...#...#...#.#...#.....#.#...#.......#.#.#...#.#...#...#.#.....#...#...#...#.#.#...#.#...#...#...#.....#.#.#.....#...........#
//#.###.#.#.#.###.#.#.#.#.#######.#######.#.#.#.#.#####.#.#.#.#.#.#.###.#.#.#####.#####.###.#.#.#.###.#.#######.#.#.#######.#######.###.#.#####
//#...#...#.#.....#.#...#.......#.....#...#...#...#.....#.#.#...#.#.#.....#.#...#.#...#...#.#.#.#...#.#...#.....#.#.#.......#...#...#...#.#...#
//#.#.#####.#######.#.#.#####.#.#.#.###.###.###.###.#.#####.#.###.#.#######.#.###.#.#.#.###.#.#.#.#.#.#.#.#.###.#.#.#.#.#####.#.#.###.#####.#.#
//#.#...#.#.....#...#.#.#.......#.#.......#.#...#...#.#.....#...#.#.#.......#.#...#.#.#.......#...#...#...#.#...#.#.#...#.#...#.#...#.#.....#.#
//#.###.#.#####.#.###.#.#.#######.#######.#.#.###.#.###.#######.#.#.#.#######.#.###.#.###########.###.#.###.#.###.#.###.#.#.#.#####.#.#.#####.#
//#.#.#.#.....#.#.....#...#.........#...#.#.....#.#.#...#.....#.#.#.#...#...#...#...#.......#.....#...#.....#.#.........#...#.......#...#...#.#
//#.#.#.#.#####.#.#######.#.#.#####.#.#.###.###.#.#.#.#######.#.#.#.#.#.#.#.#.###.#######.#.#.###########.###.#.#########.###########.###.#.#.#
//#...#.#...#...#...#...#.#.#...#...#.#.....#...#.#...#.....#...#.#...#.#.#.#.#.....#...#.#.#...........#.#...#.....#...#...#.#...........#.#.#
//###.#.###.#.#######.#.#.###.#.###.#.#####.#.###.#######.#.#####.###.#.#.###.#.###.#.#.#.###########.###.#.#####.#.###.###.#.#.###########.#.#
//#.#.#.#...#.#.....#.#.#.....#.....#.#.#...#.#...........#...#...#.#...#...#.#...#...#.#.#...#.....#...#.#.....#.#.......#.#.....#...#.....#.#
//#.#.#.#.#.#.#.###.#.#.#.#########.#.#.#.###.###############.#.#.#.#######.#.#.#.###.#.#.#.#.#.#.#####.#.#.###.#.#######.#.#.###.#.#.#####.#.#
//#.....#...#...#.#.#.#.#.#...#...#...#.#...#...#...........#.#.#...........#.#.#.....#.#...#...#.....#...#.#.#.#.......#.#.......#.#.....#.#.#
//#####.#.#.#####.#.#.#.###.#.###.#####.#.#####.#.#.#########.#.#.###.###.#.#.###.#####.#########.#.#.#####.#.#.#######.###.#.#####.#####.#.#.#
//#.....#.#.....#.....#.....#...#.#.......#...#.#.#.............#...#.......#.....#.....#...#...#...#.....#.#.#...#...#...#.#.#...#...........#
//#.#####.#.#####.#############.#.#.#.###.#.#.#.#.#######.###########.#.#######.#.#.#####.###.#.#######.#.#.#.#.#.#.#####.#.#.###.#.#.#######.#
//#.....#.#.........#...........#...#...#.#.#...#.#.#.........#.....#.#.#.......#.....#...#...#.........#.#...#.#.#.#.......#.....#.#.#.......#
//#.###.#.#.#.#####.#.#######.#.#.###.#.###.#####.#.#.#######.###.#.###.#.###########.###.#.#############.#.###.#.#.#.###.#.#######.#.#####.###
//#.#...#...#.#...#.#.#.....#.#.#.#...#.....#...#.#.#.#.......#...#...#.#...#.......#.....#.........#.....#.#...#...#...#.#.......#.#.........#
//#.#.###.#.###.#.#.#.#####.#.#.###.#########.#.#.#.#.#.#######.#####.#.###.#.#.#.#.###.###########.###.###.#.###.#####.#.#.#.###.#.#.#.#.###.#
//#.#.#...#.....#.#.#...#...#.#...#.#.........#.#.#.#.#.#...#...#.........#.#.#...#.#...#.........#...#.#...#.#.#.#...#.#.#...#.#...#...#.....#
//###.#.#.#.#####.#####.#.#.#.###.#.#.#######.###.#.#.#.#.#.#.###########.#.#####.#.#.###.#######.###.###.#.#.#.#.#.#.#.#.#####.#############.#
//#...#.........#.......#.#.#.#.#...#.....#...#...#.#.#...#.#...#...#...#.#.#.....#.#.....#.....#...#.....#...#...#.#...#.....#...#...#.......#
//#.#####.#.###.#########.#.#.#.#########.#.###.###.#.#####.#.#.#.#.#.#.###.#.#####.###.#######.###.#.#####.###.###.#########.#.#.#.###.#######
//#.#...#...#...#.........#.#.#.........#.#...#...#.#.....#.#.#...#...#.#...#.....#.....#.....#...#.#...#...#.....#...#.#.......#...#...#.....#
//#.#.#.#.#.#.#######.#####.#.#.#.#.###.#.###.###.#.#.#.#.#.###########.#.###.###.#######.###.#.###.#.###.###.#.#####.#.#.###########.#######.#
//#.#.#...#.#.#.......#.....#...#.#...#.#.#.#.....#.#...#.#...........#.#.#.....#.....#...#.#...#...#.#...#.#...#.....#.......#.......#.......#
//#.#.###.#.#.#.#######.#######.#.###.###.#.#######.#####.###########.#.#.###########.#.#.#.###.#.#####.###.###.#.#.#########.#.#######.#.#####
//#.#...#...#...#.....#.#...#.#.#...#.....#...........#.#.#.........#.#...............#.#.#...#.#.....#.#.......#.#.#.......#.#.....#.#.#.....#
//#.###.#.#######.#####.#.#.#.#.###.#######.###.###.#.#.#.#.###.#.###.###########.#.#####.#.#.#.#####.#.###.#####.###.#.###.#####.#.#.#.#####.#
//#...#.#.............#...#...#...#.....#...#.#.....#...#.#...#.#.#...#...#.....#...#.....#.#.....#...#.........#...#.#...#.....#...#.......#.#
//#.#.#.#.###########.#######.###.#####.#.###.#####.#####.###.#.#.#.###.#####.#.#######.###.#####.#.###########.###.#.#.#.###.#.#.#.#########.#
//#.#.#.............#.....#.....#...#.#...#.......#.......#...#.#.#.#...#...#.#.........#...#...#.#...#.......#...#.....#.#...#.#...........#.#
//#.#####.###.#.#.#.###.#.#.#######.#.#####.#.#.#.#.#.#####.###.###.#.#.#.#.#.###.###########.#.#####.#.#####.###.#########.#####.#.#######.#.#
//#.#.......#.#...#...#.#.#...#.....#...#.....#.#...#.#...#.#...#...#.....#.#...#.....#...#...#.#.....#.#...#.#.....#...#...#.............#.#.#
//#.#.###.###.#######.#.#.#.#.#.#####.#.#.###.#.#####.#.###.#.#.#.#.#######.#.#######.#.#.#.#.#.#.#####.#.#.#.#.#.###.#.#.#.#.###.#.#.#####.#.#
//#.#.#.#.....#.........#...#.#...#...#.......#.#.#...#.......#.#.#.......#.#.#.....#...#...#.......#...#.#.#...#.#...#...#.#...#...#...#...#.#
//#.#.#.#.#####.#.#####.###.#.###.#.#######.###.#.#.#######.###.#.#####.###.#.#.###.#.#######.#.###.#.###.#.###.###.#####.#####.#.#.###.#.###.#
//#.#.#.........#.#.....#...#.#.#.#.........#...#.#.#.....#.#...#.#...#.#...#.#...#.#...#.....#.#...#.#...#.....#...#...........#.....#...#...#
//#.#.#.#####.###.#.#######.#.#.#.#######.###.###.#.###.#.###.#.#.#.#.###.#######.#.###.#.#######.###.#.#########.#######.#.#####.#.#.#######.#
//#.#.#...#...#...#.......#.#...#.....#...#.......#...#.#.....#.#.#.#...#.#.......#.#.#.#.........#...#...#.....#.#.....#.#...#.....#.#.....#.#
//#.#.###.#.###.#########.#####.#####.#.###.#########.#.#######.#.#.###.#.#.#######.#.#.###########.#.###.#.###.#.#.###.#.###.###.#.#.#.#.#.#.#
//#.........#...#.....#.#.....#.....#.#.......#.......#...#.#...#.......#...#.....#.#.#.#...#.......#.....#...#.#.....#.#.#.#...#.#.....#.#...#
//#.###.#.#.#.#.###.#.#.#####.#.#####.#.#######.#.#.#####.#.#.#########.#####.###.#.#.#.#.#.#####.###.#######.#.###.###.#.#.###.#.#.###.#.#####
//#...#.#.#.#.#.....#.#.#...#.#.#.....#.#...#...#...#.....#.......#.....#.....#...#.#.....#.......#.#...#...#.#...#.#...#.....#.#.#...#.#.....#
//#.###.#.#.#.#.#####.#.#.#.#.#.#.#####.#.###.#######.#.###.#######.###.#.#####.###.###############.###.#.###.###.#.#.#####.###.#.#.#.#.#.###.#
//#.....#.#.#...#...#...#.#.#...#...#.....#...#.....#.#...#.#.......#.#...#...#.#...#.....#.....#.......#.#...#...#.#.#.....#...#...#.#.#...#.#
//#.#######.###.###.#.#.#.#.#.#####.###.###.###.###.#####.###.#######.###.###.#.#.###.###.#####.#.#######.#.#####.###.#.#####.#####.#.#.#####.#
//#...#.....#.....#.#.#...#.#.....#...#.#...#...#.........#...#...#...........#.#.....#...#.....#.#.......#.....#.....#...#.#.....#.#.#...#...#
//###.#.#####.#.#.#.#.#.###.#########.###.###.#.#####.#.###.###.###.#####.#####.#######.###.#####.###.#########.#########.#.#.###.#.#.#.#.#.#.#
//#.......#...#...#...#.#.............#...#...#...#.#.#...#...#.......#.#.........#.....#.....#.......#...#...#...#.....#.#...#.#.#.#.#.....#.#
//#.#.#.#.#.###.#######.###########.###.###.#####.#.#.###.###.#######.#.###########.#####.###.#.#######.#.#.#.###.#####.#.#.#.#.#.#.#.#.###.###
//#.#...#.#...#.#.....#.....#...#...#...#...#...#.#.........#.....#.#.....#...#...#.#...#.#.#.#.#.#.....#...#...#.#.....#...#.#.#.#...#...#...#
//#.#.###.###.#.#.###.#####.#.###.###.###.###.###.#########.#####.#.#####.###.#.#.#.#.###.#.#.#.#.#.###########.#.#.#####.###.#.#.#.###.#.#.#.#
//#.#.......#.#...#.#.....#.#.#.....#...#.#.....#.#...#...#.#.....#.#.......#.#.#...#.#.....#.#.#.....#...#.......#.........#...#.#.#.........#
//#.#.#.#####.#####.#####.#.#.#.#######.#.#.###.#.#.#.#.#.#.#.#####.#.#.#.#.#.#.#####.#.#####.#.#.###.#.###.#########.#.#####.###.#.###.###.#.#
//#...#.#.....#...#.....#.#.#.#.#.#.....#.#.#...#...#.#.#.#.#...#.....#.....#.#.....#.#.#...#...#...#.#.........#...#.#.......#...#...#.#...#.#
//#.#.###.#####.###.###.#.#.#.#.#.#.#####.###.#.#####.#.#.#.###.#####.#######.#####.#.#.#.#.#.#####.#.#######.#.#.#.#.#########.###.#.#.#####.#
//#.#...#...#...#...#.#.#.#.#.#...#.#.....#...#.#.#...#.#.....#.....#...#.....#.#...#...#.#.#.......#.#.....#.#.#.#.#...#.......#...#.#.....#.#
//###.#.###.#.#.#.###.#.#.#.#.###.#.#####.#.###.#.#.###.#########.#.###.#.#.#.#.#.#######.#.#########.#.###.#.#.#.#.#####.###########.#.###.#.#
//#...#.....#.#...#...#.#...#.....#.....#...#.....#.#.....#.....#.#...#.#.#.....#.#.......#.......#.....#.#...#...#...#...#.........#.#...#...#
//#.#.#######.#####.#.#.###.###########.###.#######.#.#####.###.#####.#.###.###.#.#.###.#########.#.#.#.#.#####.#####.#.###.#.#.###.#.#.#####.#
//#...#.....#...#...#.#.....#.........#.#...#.......#...#...#.#.....#.#.....#.#.#.#.........#.......#...#.#...#.....#.#...#.#.#...#...#.......#
//###.#.#.#.###.###.#########.###.#####.#.###.#######.###.###.#####.#.#######.#.#.#.#######.#.#.#.#####.#.#.#.#####.#.###.#.#.###.###.###.#.###
//#...#.#.#...#.....#...#.....#.#.....#.#.#.#...#...#.#...#.....#...#.#...#.....#.#.......#...#.#.......#.#.#...#...#...#.#.#.#.#...#.#...#...#
//#.#.###.#########.#.#.#.#####.#.###.#.#.#.###.###.#.#.#######.#.###.#.###.#####.###########.#.#.#.#####.#.###.#######.#.#.#.#.###.###.#.###.#
//#...#...#.......#.#.#...#.........#.#.#.....#...#...#...#.....#.#...#.#...#...#.#...#.....#.#.#.#.....#.#...#.#.......#.#.#...#.#.....#.#...#
//#.#.#.###.#.#####.#.#####.###.###.#.#.#####.###.#.#####.#.###.#.###.#.#.#####.#.#.#.#.###.###.#######.#.###.#.#.#.#####.#.###.#.#######.#.###
//#.#.#.#...#.....#.#.#.....#...#...#...#...#...#.#.#...#.#.#...#...#.#...#.....#.#.#...#.#...#.........#.#...#...#.#...#.#...#...............#
//###.#.#.#######.#.#.#####.#.#.#.#######.#.#.###.###.#.#.#.#.#####.#.###.#.#.###.#.#####.###.###.#######.#.#####.###.#.#.#.#.#.#####.#.#.###.#
//#...#...#.....#...#.....#...#.#.#.......#.....#.#...#...#.#.....#.....#.#.#...#.#...#.....#...#.......#.#.....#.#...#...#.#.........#...#...#
//#.###.#####.###########.#.###.#.###.#########.#.#.#######.#######.###.#.###.#.#.###.#.#######.#######.#.#####.###.###.#.#######.#.#####.#.###
//#...#.#...#...#.....#...#.#.#.#.....#.......#.#.#...#.......#...#.#...#...#.#.#.#...#.......#.....#...#.....#.#...#...#.......#.#...#...#...#
//#.#.#.#.#.###.#.###.#.###.#.#.#########.###.#.#.###.#######.#.#.#.#.#####.###.#.#.###.#####.#####.###.#####.#.#.###.#########.#.###.#.#.###.#
//#.#.#...#.....#...#...#.#...#.#.#.......#.#.#.#.#.........#...#...#.....#.....#.#.#.#.#...#.....#...#.....#.#.#...#.........#.#.#.#.#.#...#.#
//#.#.#####.#######.#####.#.###.#.#.#.#####.#.#.#.#.#.#.###.#.#######.###.#####.#.#.#.#.###.#.#######.#####.#.#.###.#######.#.#.#.#.#.#.#.#.#.#
//#.#...#...#.......#.....#.#...#.#.#.........#.#.#.#.....#.#...#.............#.#.#.#.#.#...#.....#...#...#.#.#...#.#.....#.#.#...#...#...#.#.#
//#.###.#.###.#######.#.###.#.###.#.###.#######.#.#.#.###.#.###.#.###########.###.#.#.#.#.#.#####.#.###.#.#.#.###.#.#.###.###.#####.#####.#.#.#
//#.#...#...#.#.......#.#...#.#...#.#.#...#...#...#.#...#.#.#...#.#.....#.....#...#.#.#.#.#.#.......#...#.#...#.#...#.#.....#.....#.....#.#.#.#
//###.#.#####.#####.###.#.###.#.#.#.#.###.#.#.###.#.###.#.#.###.###.###.#.#####.###.#.#.#.#.###.#####.#####.#.#.#####.#####.#####.#####.#.#.#.#
//#...#.#.....#...#.....#.#.#.#.#.#.#...#...#.....#.#.#.#.#...#...#...#...#...#.#...#.#.......#...........#...#.....#...#.............#.#...#.#
//#.#.###.#####.#.#.###.#.#.#.#.###.###.###########.#.#.#.###.###.###.#####.#.#.#.#.#.#######.###########.#.###.###.###.#.###########.#.#.###.#
//#.#.#...#.....#.#.#.#.....#.#.#.......#...#.......#...#...#.....#...#.....#.#.#.#.#.....#.#.....#.............#.#.#...#.......#.....#...#.#.#
//#.#.#.#####.###.#.#.#######.#.#.#######.#.#.###.#########.###.#.#.###.#####.#.###.#.###.#.#####.#.#####.#######.#.#.#######.#.#########.#.#.#
//#.#.#.#.....#.#.#.....#.....#.....#...#.#...#...#.........#...#...#...#...#.#.....#.#.#.......#.#...#...#.#.......#.........#.............#.#
//#.#.#.#.#####.#.###.###.###.#######.#.#.#.###.###.###.###.#.#####.#.###.###.###.###.#.#.#######.#.#.###.#.#.#########.###.#############.#.#.#
//#.#.#.#.......#...#.................#.#.......................#...#.#.....#.........#...#.......#.#...#.#.#.............#...#.........#.#...#
//#.#.#.#.#.###.###.#.#.#.#####.#######.#.#.#.#######.#.#######.#.###.#####.#####.#####.###.###########.#.#.#.#########.#.#.###.#####.#.#.#####
//#...............#.....#.#...........#.#...#.....#.#.........#.#...#.#.....#.#...#...#.........................#.....#.#.#...#.#.#...#...#...#
//#.#.#.#.###.#.###.#.#.###.#########.#.#####.###.#.#.#.#####.#.###.#.#.###.#.#.#.#.#.#.#####.#.###.#.#.#####.#.###.#.#.#.###.#.#.#.#####.###.#
//#.#.#.#.#.#.#.#...#.#...#.#...#.................#...#.................#.#.#.#.#...#...#.....#.#...#...#...#.......#...#...#...#.#.#...#.#...#
//#.###.#.#.#.#.#.###.###.#.###.#.#.#####.#.#.#.#.#####.#.#.###.#.#.#.#.#.#.#.#.#.#######.#######.#####.#.#.#.#########.###.#.###.#.#.#.#.#.#.#
//#...#.#...#.#.#...#.#...#.#...#.#.......#...#.#.......#.#.........#...#.#...#...........#.......#...#.#.#.......#.#...#.#.#.#...#.#.#...#.#.#
//#.#.#.#####.#.###.###.#.#.#.###.#######.#.#.#.#####.#.#.#.#############.###.###########.#.###.###.###.#.###.###.#.#.#.#.#.#.#.#.#.#.#####.###
//#.#.#.....#.#...#...#.....#...#.#...#...#.................#...#.....#.........................#.......#.#...#...#.......#.....#.#.#...#.....#
//#.#.#####.#.###.###.###.#.###.#.###.#.#####.###.#.#.#.#.###.#.#.###.#.#######.###.###.###.#.#.#######.#.#.#.#.#######.###.#######.###.#.###.#
//#.#.....#.#...#...#.....#.....#...#.#.......#...#.#.#.#.#...#.#.#.#.#...#...#.....#.#.....#.#.......#.#.#...#...#...#.#...#.......#...#...#.#
//#.###.###.###.#.#######.#.#######.#.#########.#.###.#.###.###.#.#.#.###.#.#.#.#####.#######.#######.###.###.###.#.#.#.#.#.#.#######.#######.#
//#S..#.........#...................#...........#.....#.......#.....#.....#.#.......................#...........#...#.........#...............#
//#############################################################################################################################################";

//var smallInput =
//@"#################
//#...#...#...#..E#
//#.#.#.#.#.#.#.#.#
//#.#.#.#...#...#.#
//#.#.#.#.###.#.#.#
//#...#.#.#.....#.#
//#.#.#.#.#.#####.#
//#.#...#.#.#.....#
//#.#.#####.#.###.#
//#.#.#.......#...#
//#.#.###.#####.###
//#.#.#...#.....#.#
//#.#.#.#####.###.#
//#.#.#.........#.#
//#.#.#.#########.#
//#S#.............#
//#################";

//var smallest =
//@"###############
//#.......#....E#
//#.#.###.#.###.#
//#.....#.#...#.#
//#.###.#####.#.#
//#.#.#.......#.#
//#.#.#####.###.#
//#...........#.#
//###.#.#####.#.#
//#...#.....#.#.#
//#.#.#.###.#.#.#
//#.....#...#.#.#
//#.###.#.#.#.#.#
//#S..#.....#...#
//###############";

//var input = smallInput;
//input = fullInput;
////input = smallest;
//var timer = System.Diagnostics.Stopwatch.StartNew();

//var result = long.MaxValue;

//var gridInput = input.Split(Environment.NewLine).Select(x => x.ToArray()).ToArray();
//var grid = new List<(short x, short y)>();
//var height = gridInput.Count();
//var width = gridInput[0].Count();

//var start = default((short, short));
//var target = default((short, short));
//for (short y = 0; y < height; y++)
//{
//    for (short x = 0; x < width; x++)
//    {
//        var item = gridInput[y][x];
//        if (item != '#')
//        {
//            var entry = (x, y);
//            grid.Add(entry);
//            if (item == 'S')
//            {
//                start = entry;
//            }
//            if (item == 'E')
//            {
//                target = entry;
//            }
//        }
//    }
//}
//var pq = new PriorityQueue<(List<(short x, short y)> maze, (short x, short y) position, char facing, long score, List<(short x, short y)> pathTaken), long>();
//pq.Enqueue((maze: grid, position: start, facing: 'E', 0, new List<(short x, short y)> { start }), 0);

//var directions = new[] {
//    (icon: 'E', x: 1, y: 0),
//    (icon: 'W', x: -1, y: 0),
//    (icon: 'N', x: 0, y: -1),
//    (icon: 'S', x: 0, y: 1),
//};

//char InverseDirection(char x)
//    => x switch
//    {
//        'E' => 'W',
//        'W' => 'E',
//        'S' => 'N',
//        'N' => 'S',
//        _ => throw new NotImplementedException()
//    };

//int i = 0;

//var bestPaths = new List<List<(short x, short y)>>();
//var deadends = new HashSet<(short x, short y)>();
//while (pq.Count > 0)
//{
//    var (maze, position, facing, score, pathTaken) = pq.Dequeue();
//    if (i % 100 == 0)
//    {
//        Console.WriteLine($"{i}i {pq.Count}queue {score}score {deadends.Count}dead");
//    }
//    i++;

//    maze = maze.Except(deadends).ToList();
//    if (score > result)
//    {
//        break;
//    }
//    if (position == target)
//    {
//        result = Math.Min(result, score);
//        if (score == result)
//        {
//            bestPaths.Add(pathTaken);
//        }
//    }

//    var deadEnd = 3;
//    foreach (var direction in directions.Where(x => x.icon != InverseDirection(facing)))
//    {
//        var other = maze.SingleOrDefault(x => x.x == position.x + direction.x && x.y == position.y + direction.y);
//        if (other == default || deadends.Contains(other)) { deadEnd--; continue; }
//        var cost = direction.icon == facing ? 1 : 1001;
//        var newTotal = score + cost;
//        var newPathTaken = pathTaken.ToList();
//        newPathTaken.Add(other);
//        pq.Enqueue((maze.Where(x => x != position).ToList(), other, direction.icon, newTotal, newPathTaken), newTotal);
//    }
//    if (deadEnd == 0)
//    {
//        deadends.Add(position);
//    }
//}

//result = bestPaths.SelectMany(x => x).Distinct().Count();

//timer.Stop();
//Console.WriteLine(result);
////PrintGrid();
//Console.WriteLine(timer.ElapsedMilliseconds + "ms");
//Console.ReadLine();

////void PrintGrid()
////{
////    var sb = new StringBuilder();
////    WriteGrid(sb);
////    Console.WriteLine(sb);
////}
////void WriteGrid(StringBuilder sb)
////{
////    for (int y = 0; y < width; y++)
////    {
////        for (int x = 0; x < height; x++)
////        {
////            sb.Append(bestPath.SingleOrDefault(n => n.x == x && n.y == y) != default ? 'X' : '.');
////        }
////        sb.AppendLine();
////    }
////}