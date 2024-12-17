﻿using System.Text;

var fullInput =
@"#############################################################################################################################################
#.......#...#.....#...........#.....#.......#.......#.............#.........#...........#...............#.......#.....#.......#............E#
###.###.#.#.###.###.#####.###.#.#####.#.#####.###.###.#########.###.#.#####.#.###.###.#.#######.#####.#.#.#.###.###.#.#.#.#.#.#.#.#########.#
#...............#...#.....#.....#.....#.......#...#...#...#.....#...#...#...#...#.....#...................#.#.#...#.#.................#...#.#
#.#.#.#.#.#.#####.###.#####.#####.#############.#.#.#####.#.#.###.###.#.#######.#####.#######.#####.#.#.#.#.#.###.#####.#.###.#####.#.#.#.#.#
#.#...#.#...#.....#.#...#.....#...#.....#.......#.#.....#.#.#.#.....#...#.......#...#...#.#...#...#.#.#...#.#...#.......#...........#.#.#...#
#.#.#.#.#.#.#.#####.###.#####.#.#####.#.#.#############.#.#.#.#.#####.#.#.#######.###.#.#.#.###.###.#.#####.#.#######.#.#.###.###.#.###.###.#
#.#...#.#.#.#.....#...#.................#.#...........#.#.#.#.................#...................#.......#.#.#.....#...#.........#.#.....#.#
#.#.###.###.#####.###.###.#############.#.#.#########.#.#.#.###.#.#.#.#######.#.#.#.#.###.#######.#.#.#####.#.#.###.#.#####.#.#######.###.#.#
#.#...........#...#.....#.#.......#.....#...#...#...#.....#.#...#.............#.#.#.#.#...#.....#...#.....#.#...............#...#.....#...#.#
#.#.#####.#####.###.#.###.#.#####.#.#.###.###.#.#.#.#####.#.#.###.###.#.#.###.###.#.#.#.###.###.###.#.###.#.#.###.###.#.#####.#.#.#####.#.#.#
#.......#.#...........#...#.#...#.#.#.#.......#...#...#...#.....#.......#...#...#.#.#.#.#...#.#...#.#.#...#.#...#.#.....#.....#...#.....#...#
#.#.###.###.#.###.#.###.###.#.#.#.#.#.#.#####.#######.#####.#####.###.#####.###.#.#.#.#.###.#.###.###.###.#.#.#.#.#.#.###.#########.#########
#...#.#.#...#...#...#...#...#.#.#...#.#.#.....#...#...#...#.#...#.....#...#...#...#.................#...#...............#...#...............#
###.#.#.#.###.###.###.###.###.#######.#.#######.#.#.#.#.#.###.#.#####.###.#.#####.#.#.#######.#.###.###.#####.#####.#.#.###.###.###########.#
#.#.#.#.....#.#...#...#...#...........#.....#...#.#...........#...#.....#.#.......#.#.#...#...#...#.#...#...#.....#...#...#...#.#...#...#...#
#.#.#.###.###.#.###.###.#######.###.#.#####.#.###.###############.#####.#.#########.#.#.#.#.#####.#.#.#####.#.###.#.#.###.###.###.#.###.#.###
#.........#...#.........#.....#.#...#.....#.#.#.#.........#.....#...#.....#.....#...#...#.#.#...#...#...#...#.#...#.#.#.#...#.#...#.#...#.#.#
#.#######.#.#####.#######.###.#.#.#######.#.#.#.#########.#.###.###.#.#####.###.#.#######.#.###.#######.#.#.#.#.#####.#.###.#.#.###.#.###.#.#
#...#.......#...#.#.......#...#.#.....#...#...#.....#...#.#.#...#...#.#.....#.#.#.....#...#.#.....#.....#.#.#.......#.#.......#.#.#.#.....#.#
#.###.###.#.#.#.#.#.#######.###.#####.#########.#.#.#.###.#.#.#.#.#####.#####.#.#####.#.###.#.###.#.#####.#.#.#####.#.#######.#.#.#.#####.#.#
#.#...#.#...#.#.#...#.....#.#.......#.......#.....#...#...#.#.#.#.......#.#.....#.....#...#...#.#...#.....#...#.#...#.#...#.............#...#
#.#.###.#.###.#.#####.###.#.#######.#######.#.###.#####.#####.###########.#.#####.#####.#.#####.#####.#######.#.#.###.#.#.#####.#.#.#.#.#####
#.#...#...#.#.#.......#...#.......#.#.....#.....#.....#.....#.........#.....#.....#...#.#.......#.....#.#.....#.#.#...#.#.........#...#.....#
#.###.#.#.#.#.#####.#############.#.#.###.#####.#####.#####.#.###.#.#.#.###.#.#####.###.#######.#.#.###.#.#.###.#.#.#.#.###################.#
#.......#...#.#.....#...........#.#.#...#.#...........#.....#...#.#...#.#.....#.....#...#.....#...#.#.....#.....#.#.#...#...#...#...#.....#.#
#######.#.#.#.#.#.###.#########.#.#.#####.#.#.#######.#.#######.#.#####.#.#####.#.#.#.###.#.#.#####.#.#########.#.#.#.#.#.#.#.###.#.#.###.#.#
#.......#...#.#.......#.......#...#.......#.....#...#.#.#...#...#.....#.#...#.......#...#.#.#.#...#.#...........#.#.#...#.#.#.#...#...#...#.#
#.#.###.#.#.#.###########.###.#####.#######.###.#.#.###.#.#.#.#######.#.###.#.#####.###.###.#.###.#.#.#########.#.#.#####.#.#.#.#.#.###.###.#
#.#.#.....#.#.#.#.........#...#.....#.....#...#...#.#...#.#...#.............#.....#...#...#.#...#.#.#.#.......#.#.#.......#.#.#...#...#.#...#
#.###.#.#.###.#.#.#.#######.###.#.###.###.#####.#.#.#.###.###.###.#.#####.#.###.#.#.#####.#.###.#.#.#.#.#####.###.#########.#.###.###.#.#.#.#
#...#.#.#.....#.#.#.....#.#.#...#.#.....#.......#.#.#.#...#...#...#...........#.#.#.#...#...#...#.#.#.#.....#...#.#.............#...#.#...#.#
#.#.#.#.#######.#.#####.#.#.#.###.#.###.#######.###.#.###.#.###.#####.#######.###.###.#.#####.###.#.###.#######.#.#.###########.###.#.#.#####
#.#...#.............#.#.#.#.#.....#...#...#.........#...#.#.#.........#.......#...#...#.....#.#...#...#.#...#...#.#.....#...#...............#
#.#################.#.#.#.#.#####.###.###.#.###########.#.#.#.###.#####.#.#####.###.#####.###.###.###.#.#.#.#.###.#.###.#.#.#.#####.#.#.#.#.#
#...........#.....#...#.#...#...#...#...#.......#.......#.#.#...#.#.....#.........#.#...#...#.....#.#.#.#.#.#...#.#...#.#.#.#...........#.#.#
###########.#.###.###.#.#.#####.###.###.###.#####.#######.#.#.#.#.#.#######.#.###.#.#.#.###.#####.#.#.#.#.#.###.#.#.#.###.#.###.#.#######.#.#
#...#.......#...#...#.#.#.#.......#.#.#...#.#.....#.....#.#.#.....#.#.....#.#.#...#.....#.#.........#.#.#.#.....#...#.#...#...#.#.........#.#
#.#.#.#####.#.#.###.###.#.#.###.###.#.###.#.#.#####.#.#.#.#.###.#.#.#.###.#.###.###.###.#.###########.#.#.###.#.#####.#.#####.#############.#
#.#...#...#.#.#.#.#.....#.#...#.#...#...#.#.#.#.....#.#...#.#...#...#...#.#...#.#.....#.#...#.....#...#.#.#...#.....#.#...#...#...#.......#.#
#######.#.#.#.#.#.#######.#.#.###.###.#.#.###.###.###.#.###.#.#####.###.#####.#.#.#.###.###.#.###.#.###.#.#.#.#######.#.#.#.###.#.#.#####.#.#
#.....#.#...#.#...#...#...#.#...#.....#.#...#.......#.#.#...#.#...#...#.#.....#...#...#...#.#.#...#.#...#...#...#.....#.#.#.....#...........#
#.###.#.#.#.###.#.#.#.#.#######.#######.#.#.#.#.#####.#.#.#.#.#.#.###.#.#.#####.#####.###.#.#.#.###.#.#######.#.#.#######.#######.###.#.#####
#...#...#.#.....#.#...#.......#.....#...#...#...#.....#.#.#...#.#.#.....#.#...#.#...#...#.#.#.#...#.#...#.....#.#.#.......#...#...#...#.#...#
#.#.#####.#######.#.#.#####.#.#.#.###.###.###.###.#.#####.#.###.#.#######.#.###.#.#.#.###.#.#.#.#.#.#.#.#.###.#.#.#.#.#####.#.#.###.#####.#.#
#.#...#.#.....#...#.#.#.......#.#.......#.#...#...#.#.....#...#.#.#.......#.#...#.#.#.......#...#...#...#.#...#.#.#...#.#...#.#...#.#.....#.#
#.###.#.#####.#.###.#.#.#######.#######.#.#.###.#.###.#######.#.#.#.#######.#.###.#.###########.###.#.###.#.###.#.###.#.#.#.#####.#.#.#####.#
#.#.#.#.....#.#.....#...#.........#...#.#.....#.#.#...#.....#.#.#.#...#...#...#...#.......#.....#...#.....#.#.........#...#.......#...#...#.#
#.#.#.#.#####.#.#######.#.#.#####.#.#.###.###.#.#.#.#######.#.#.#.#.#.#.#.#.###.#######.#.#.###########.###.#.#########.###########.###.#.#.#
#...#.#...#...#...#...#.#.#...#...#.#.....#...#.#...#.....#...#.#...#.#.#.#.#.....#...#.#.#...........#.#...#.....#...#...#.#...........#.#.#
###.#.###.#.#######.#.#.###.#.###.#.#####.#.###.#######.#.#####.###.#.#.###.#.###.#.#.#.###########.###.#.#####.#.###.###.#.#.###########.#.#
#.#.#.#...#.#.....#.#.#.....#.....#.#.#...#.#...........#...#...#.#...#...#.#...#...#.#.#...#.....#...#.#.....#.#.......#.#.....#...#.....#.#
#.#.#.#.#.#.#.###.#.#.#.#########.#.#.#.###.###############.#.#.#.#######.#.#.#.###.#.#.#.#.#.#.#####.#.#.###.#.#######.#.#.###.#.#.#####.#.#
#.....#...#...#.#.#.#.#.#...#...#...#.#...#...#...........#.#.#...........#.#.#.....#.#...#...#.....#...#.#.#.#.......#.#.......#.#.....#.#.#
#####.#.#.#####.#.#.#.###.#.###.#####.#.#####.#.#.#########.#.#.###.###.#.#.###.#####.#########.#.#.#####.#.#.#######.###.#.#####.#####.#.#.#
#.....#.#.....#.....#.....#...#.#.......#...#.#.#.............#...#.......#.....#.....#...#...#...#.....#.#.#...#...#...#.#.#...#...........#
#.#####.#.#####.#############.#.#.#.###.#.#.#.#.#######.###########.#.#######.#.#.#####.###.#.#######.#.#.#.#.#.#.#####.#.#.###.#.#.#######.#
#.....#.#.........#...........#...#...#.#.#...#.#.#.........#.....#.#.#.......#.....#...#...#.........#.#...#.#.#.#.......#.....#.#.#.......#
#.###.#.#.#.#####.#.#######.#.#.###.#.###.#####.#.#.#######.###.#.###.#.###########.###.#.#############.#.###.#.#.#.###.#.#######.#.#####.###
#.#...#...#.#...#.#.#.....#.#.#.#...#.....#...#.#.#.#.......#...#...#.#...#.......#.....#.........#.....#.#...#...#...#.#.......#.#.........#
#.#.###.#.###.#.#.#.#####.#.#.###.#########.#.#.#.#.#.#######.#####.#.###.#.#.#.#.###.###########.###.###.#.###.#####.#.#.#.###.#.#.#.#.###.#
#.#.#...#.....#.#.#...#...#.#...#.#.........#.#.#.#.#.#...#...#.........#.#.#...#.#...#.........#...#.#...#.#.#.#...#.#.#...#.#...#...#.....#
###.#.#.#.#####.#####.#.#.#.###.#.#.#######.###.#.#.#.#.#.#.###########.#.#####.#.#.###.#######.###.###.#.#.#.#.#.#.#.#.#####.#############.#
#...#.........#.......#.#.#.#.#...#.....#...#...#.#.#...#.#...#...#...#.#.#.....#.#.....#.....#...#.....#...#...#.#...#.....#...#...#.......#
#.#####.#.###.#########.#.#.#.#########.#.###.###.#.#####.#.#.#.#.#.#.###.#.#####.###.#######.###.#.#####.###.###.#########.#.#.#.###.#######
#.#...#...#...#.........#.#.#.........#.#...#...#.#.....#.#.#...#...#.#...#.....#.....#.....#...#.#...#...#.....#...#.#.......#...#...#.....#
#.#.#.#.#.#.#######.#####.#.#.#.#.###.#.###.###.#.#.#.#.#.###########.#.###.###.#######.###.#.###.#.###.###.#.#####.#.#.###########.#######.#
#.#.#...#.#.#.......#.....#...#.#...#.#.#.#.....#.#...#.#...........#.#.#.....#.....#...#.#...#...#.#...#.#...#.....#.......#.......#.......#
#.#.###.#.#.#.#######.#######.#.###.###.#.#######.#####.###########.#.#.###########.#.#.#.###.#.#####.###.###.#.#.#########.#.#######.#.#####
#.#...#...#...#.....#.#...#.#.#...#.....#...........#.#.#.........#.#...............#.#.#...#.#.....#.#.......#.#.#.......#.#.....#.#.#.....#
#.###.#.#######.#####.#.#.#.#.###.#######.###.###.#.#.#.#.###.#.###.###########.#.#####.#.#.#.#####.#.###.#####.###.#.###.#####.#.#.#.#####.#
#...#.#.............#...#...#...#.....#...#.#.....#...#.#...#.#.#...#...#.....#...#.....#.#.....#...#.........#...#.#...#.....#...#.......#.#
#.#.#.#.###########.#######.###.#####.#.###.#####.#####.###.#.#.#.###.#####.#.#######.###.#####.#.###########.###.#.#.#.###.#.#.#.#########.#
#.#.#.............#.....#.....#...#.#...#.......#.......#...#.#.#.#...#...#.#.........#...#...#.#...#.......#...#.....#.#...#.#...........#.#
#.#####.###.#.#.#.###.#.#.#######.#.#####.#.#.#.#.#.#####.###.###.#.#.#.#.#.###.###########.#.#####.#.#####.###.#########.#####.#.#######.#.#
#.#.......#.#...#...#.#.#...#.....#...#.....#.#...#.#...#.#...#...#.....#.#...#.....#...#...#.#.....#.#...#.#.....#...#...#.............#.#.#
#.#.###.###.#######.#.#.#.#.#.#####.#.#.###.#.#####.#.###.#.#.#.#.#######.#.#######.#.#.#.#.#.#.#####.#.#.#.#.#.###.#.#.#.#.###.#.#.#####.#.#
#.#.#.#.....#.........#...#.#...#...#.......#.#.#...#.......#.#.#.......#.#.#.....#...#...#.......#...#.#.#...#.#...#...#.#...#...#...#...#.#
#.#.#.#.#####.#.#####.###.#.###.#.#######.###.#.#.#######.###.#.#####.###.#.#.###.#.#######.#.###.#.###.#.###.###.#####.#####.#.#.###.#.###.#
#.#.#.........#.#.....#...#.#.#.#.........#...#.#.#.....#.#...#.#...#.#...#.#...#.#...#.....#.#...#.#...#.....#...#...........#.....#...#...#
#.#.#.#####.###.#.#######.#.#.#.#######.###.###.#.###.#.###.#.#.#.#.###.#######.#.###.#.#######.###.#.#########.#######.#.#####.#.#.#######.#
#.#.#...#...#...#.......#.#...#.....#...#.......#...#.#.....#.#.#.#...#.#.......#.#.#.#.........#...#...#.....#.#.....#.#...#.....#.#.....#.#
#.#.###.#.###.#########.#####.#####.#.###.#########.#.#######.#.#.###.#.#.#######.#.#.###########.#.###.#.###.#.#.###.#.###.###.#.#.#.#.#.#.#
#.........#...#.....#.#.....#.....#.#.......#.......#...#.#...#.......#...#.....#.#.#.#...#.......#.....#...#.#.....#.#.#.#...#.#.....#.#...#
#.###.#.#.#.#.###.#.#.#####.#.#####.#.#######.#.#.#####.#.#.#########.#####.###.#.#.#.#.#.#####.###.#######.#.###.###.#.#.###.#.#.###.#.#####
#...#.#.#.#.#.....#.#.#...#.#.#.....#.#...#...#...#.....#.......#.....#.....#...#.#.....#.......#.#...#...#.#...#.#...#.....#.#.#...#.#.....#
#.###.#.#.#.#.#####.#.#.#.#.#.#.#####.#.###.#######.#.###.#######.###.#.#####.###.###############.###.#.###.###.#.#.#####.###.#.#.#.#.#.###.#
#.....#.#.#...#...#...#.#.#...#...#.....#...#.....#.#...#.#.......#.#...#...#.#...#.....#.....#.......#.#...#...#.#.#.....#...#...#.#.#...#.#
#.#######.###.###.#.#.#.#.#.#####.###.###.###.###.#####.###.#######.###.###.#.#.###.###.#####.#.#######.#.#####.###.#.#####.#####.#.#.#####.#
#...#.....#.....#.#.#...#.#.....#...#.#...#...#.........#...#...#...........#.#.....#...#.....#.#.......#.....#.....#...#.#.....#.#.#...#...#
###.#.#####.#.#.#.#.#.###.#########.###.###.#.#####.#.###.###.###.#####.#####.#######.###.#####.###.#########.#########.#.#.###.#.#.#.#.#.#.#
#.......#...#...#...#.#.............#...#...#...#.#.#...#...#.......#.#.........#.....#.....#.......#...#...#...#.....#.#...#.#.#.#.#.....#.#
#.#.#.#.#.###.#######.###########.###.###.#####.#.#.###.###.#######.#.###########.#####.###.#.#######.#.#.#.###.#####.#.#.#.#.#.#.#.#.###.###
#.#...#.#...#.#.....#.....#...#...#...#...#...#.#.........#.....#.#.....#...#...#.#...#.#.#.#.#.#.....#...#...#.#.....#...#.#.#.#...#...#...#
#.#.###.###.#.#.###.#####.#.###.###.###.###.###.#########.#####.#.#####.###.#.#.#.#.###.#.#.#.#.#.###########.#.#.#####.###.#.#.#.###.#.#.#.#
#.#.......#.#...#.#.....#.#.#.....#...#.#.....#.#...#...#.#.....#.#.......#.#.#...#.#.....#.#.#.....#...#.......#.........#...#.#.#.........#
#.#.#.#####.#####.#####.#.#.#.#######.#.#.###.#.#.#.#.#.#.#.#####.#.#.#.#.#.#.#####.#.#####.#.#.###.#.###.#########.#.#####.###.#.###.###.#.#
#...#.#.....#...#.....#.#.#.#.#.#.....#.#.#...#...#.#.#.#.#...#.....#.....#.#.....#.#.#...#...#...#.#.........#...#.#.......#...#...#.#...#.#
#.#.###.#####.###.###.#.#.#.#.#.#.#####.###.#.#####.#.#.#.###.#####.#######.#####.#.#.#.#.#.#####.#.#######.#.#.#.#.#########.###.#.#.#####.#
#.#...#...#...#...#.#.#.#.#.#...#.#.....#...#.#.#...#.#.....#.....#...#.....#.#...#...#.#.#.......#.#.....#.#.#.#.#...#.......#...#.#.....#.#
###.#.###.#.#.#.###.#.#.#.#.###.#.#####.#.###.#.#.###.#########.#.###.#.#.#.#.#.#######.#.#########.#.###.#.#.#.#.#####.###########.#.###.#.#
#...#.....#.#...#...#.#...#.....#.....#...#.....#.#.....#.....#.#...#.#.#.....#.#.......#.......#.....#.#...#...#...#...#.........#.#...#...#
#.#.#######.#####.#.#.###.###########.###.#######.#.#####.###.#####.#.###.###.#.#.###.#########.#.#.#.#.#####.#####.#.###.#.#.###.#.#.#####.#
#...#.....#...#...#.#.....#.........#.#...#.......#...#...#.#.....#.#.....#.#.#.#.........#.......#...#.#...#.....#.#...#.#.#...#...#.......#
###.#.#.#.###.###.#########.###.#####.#.###.#######.###.###.#####.#.#######.#.#.#.#######.#.#.#.#####.#.#.#.#####.#.###.#.#.###.###.###.#.###
#...#.#.#...#.....#...#.....#.#.....#.#.#.#...#...#.#...#.....#...#.#...#.....#.#.......#...#.#.......#.#.#...#...#...#.#.#.#.#...#.#...#...#
#.#.###.#########.#.#.#.#####.#.###.#.#.#.###.###.#.#.#######.#.###.#.###.#####.###########.#.#.#.#####.#.###.#######.#.#.#.#.###.###.#.###.#
#...#...#.......#.#.#...#.........#.#.#.....#...#...#...#.....#.#...#.#...#...#.#...#.....#.#.#.#.....#.#...#.#.......#.#.#...#.#.....#.#...#
#.#.#.###.#.#####.#.#####.###.###.#.#.#####.###.#.#####.#.###.#.###.#.#.#####.#.#.#.#.###.###.#######.#.###.#.#.#.#####.#.###.#.#######.#.###
#.#.#.#...#.....#.#.#.....#...#...#...#...#...#.#.#...#.#.#...#...#.#...#.....#.#.#...#.#...#.........#.#...#...#.#...#.#...#...............#
###.#.#.#######.#.#.#####.#.#.#.#######.#.#.###.###.#.#.#.#.#####.#.###.#.#.###.#.#####.###.###.#######.#.#####.###.#.#.#.#.#.#####.#.#.###.#
#...#...#.....#...#.....#...#.#.#.......#.....#.#...#...#.#.....#.....#.#.#...#.#...#.....#...#.......#.#.....#.#...#...#.#.........#...#...#
#.###.#####.###########.#.###.#.###.#########.#.#.#######.#######.###.#.###.#.#.###.#.#######.#######.#.#####.###.###.#.#######.#.#####.#.###
#...#.#...#...#.....#...#.#.#.#.....#.......#.#.#...#.......#...#.#...#...#.#.#.#...#.......#.....#...#.....#.#...#...#.......#.#...#...#...#
#.#.#.#.#.###.#.###.#.###.#.#.#########.###.#.#.###.#######.#.#.#.#.#####.###.#.#.###.#####.#####.###.#####.#.#.###.#########.#.###.#.#.###.#
#.#.#...#.....#...#...#.#...#.#.#.......#.#.#.#.#.........#...#...#.....#.....#.#.#.#.#...#.....#...#.....#.#.#...#.........#.#.#.#.#.#...#.#
#.#.#####.#######.#####.#.###.#.#.#.#####.#.#.#.#.#.#.###.#.#######.###.#####.#.#.#.#.###.#.#######.#####.#.#.###.#######.#.#.#.#.#.#.#.#.#.#
#.#...#...#.......#.....#.#...#.#.#.........#.#.#.#.....#.#...#.............#.#.#.#.#.#...#.....#...#...#.#.#...#.#.....#.#.#...#...#...#.#.#
#.###.#.###.#######.#.###.#.###.#.###.#######.#.#.#.###.#.###.#.###########.###.#.#.#.#.#.#####.#.###.#.#.#.###.#.#.###.###.#####.#####.#.#.#
#.#...#...#.#.......#.#...#.#...#.#.#...#...#...#.#...#.#.#...#.#.....#.....#...#.#.#.#.#.#.......#...#.#...#.#...#.#.....#.....#.....#.#.#.#
###.#.#####.#####.###.#.###.#.#.#.#.###.#.#.###.#.###.#.#.###.###.###.#.#####.###.#.#.#.#.###.#####.#####.#.#.#####.#####.#####.#####.#.#.#.#
#...#.#.....#...#.....#.#.#.#.#.#.#...#...#.....#.#.#.#.#...#...#...#...#...#.#...#.#.......#...........#...#.....#...#.............#.#...#.#
#.#.###.#####.#.#.###.#.#.#.#.###.###.###########.#.#.#.###.###.###.#####.#.#.#.#.#.#######.###########.#.###.###.###.#.###########.#.#.###.#
#.#.#...#.....#.#.#.#.....#.#.#.......#...#.......#...#...#.....#...#.....#.#.#.#.#.....#.#.....#.............#.#.#...#.......#.....#...#.#.#
#.#.#.#####.###.#.#.#######.#.#.#######.#.#.###.#########.###.#.#.###.#####.#.###.#.###.#.#####.#.#####.#######.#.#.#######.#.#########.#.#.#
#.#.#.#.....#.#.#.....#.....#.....#...#.#...#...#.........#...#...#...#...#.#.....#.#.#.......#.#...#...#.#.......#.........#.............#.#
#.#.#.#.#####.#.###.###.###.#######.#.#.#.###.###.###.###.#.#####.#.###.###.###.###.#.#.#######.#.#.###.#.#.#########.###.#############.#.#.#
#.#.#.#.......#...#.................#.#.......................#...#.#.....#.........#...#.......#.#...#.#.#.............#...#.........#.#...#
#.#.#.#.#.###.###.#.#.#.#####.#######.#.#.#.#######.#.#######.#.###.#####.#####.#####.###.###########.#.#.#.#########.#.#.###.#####.#.#.#####
#...............#.....#.#...........#.#...#.....#.#.........#.#...#.#.....#.#...#...#.........................#.....#.#.#...#.#.#...#...#...#
#.#.#.#.###.#.###.#.#.###.#########.#.#####.###.#.#.#.#####.#.###.#.#.###.#.#.#.#.#.#.#####.#.###.#.#.#####.#.###.#.#.#.###.#.#.#.#####.###.#
#.#.#.#.#.#.#.#...#.#...#.#...#.................#...#.................#.#.#.#.#...#...#.....#.#...#...#...#.......#...#...#...#.#.#...#.#...#
#.###.#.#.#.#.#.###.###.#.###.#.#.#####.#.#.#.#.#####.#.#.###.#.#.#.#.#.#.#.#.#.#######.#######.#####.#.#.#.#########.###.#.###.#.#.#.#.#.#.#
#...#.#...#.#.#...#.#...#.#...#.#.......#...#.#.......#.#.........#...#.#...#...........#.......#...#.#.#.......#.#...#.#.#.#...#.#.#...#.#.#
#.#.#.#####.#.###.###.#.#.#.###.#######.#.#.#.#####.#.#.#.#############.###.###########.#.###.###.###.#.###.###.#.#.#.#.#.#.#.#.#.#.#####.###
#.#.#.....#.#...#...#.....#...#.#...#...#.................#...#.....#.........................#.......#.#...#...#.......#.....#.#.#...#.....#
#.#.#####.#.###.###.###.#.###.#.###.#.#####.###.#.#.#.#.###.#.#.###.#.#######.###.###.###.#.#.#######.#.#.#.#.#######.###.#######.###.#.###.#
#.#.....#.#...#...#.....#.....#...#.#.......#...#.#.#.#.#...#.#.#.#.#...#...#.....#.#.....#.#.......#.#.#...#...#...#.#...#.......#...#...#.#
#.###.###.###.#.#######.#.#######.#.#########.#.###.#.###.###.#.#.#.###.#.#.#.#####.#######.#######.###.###.###.#.#.#.#.#.#.#######.#######.#
#S..#.........#...................#...........#.....#.......#.....#.....#.#.......................#...........#...#.........#...............#
#############################################################################################################################################";

var smallInput =
@"#################
#...#...#...#..E#
#.#.#.#.#.#.#.#.#
#.#.#.#...#...#.#
#.#.#.#.###.#.#.#
#...#.#.#.....#.#
#.#.#.#.#.#####.#
#.#...#.#.#.....#
#.#.#####.#.###.#
#.#.#.......#...#
#.#.###.#####.###
#.#.#...#.....#.#
#.#.#.#####.###.#
#.#.#.........#.#
#.#.#.#########.#
#S#.............#
#################";

var smallest =
@"###############
#.......#....E#
#.#.###.#.###.#
#.....#.#...#.#
#.###.#####.#.#
#.#.#.......#.#
#.#.#####.###.#
#...........#.#
###.#.#####.#.#
#...#.....#.#.#
#.#.#.###.#.#.#
#.....#...#.#.#
#.###.#.#.#.#.#
#S..#.....#...#
###############";

var input = smallInput;
input = fullInput;
input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = long.MaxValue;

var gridInput = input.Split(Environment.NewLine).Select(x => x.ToArray()).ToArray();
var grid = new List<(short x, short y, char? facing)>();
var height = gridInput.Count();
var width = gridInput[0].Count();

var start = default((short, short, char?));
var target = default((short, short, char?));

var startFacing = 'E';

for (short y = 0; y < height; y++)
{
    for (short x = 0; x < width; x++)
    {
        var item = gridInput[y][x];
        if (item != '#')
        {
            var entry = (x, y, (char?)null);
            if (item == 'S')
            {
                entry.Item3 = startFacing;
                start = entry;
            }
            if (item == 'E')
            {
                target = entry;
            }
            grid.Add(entry);
        }
    }
}

var directions = new[] {
    (icon: 'E', x: 1, y: 0),
    (icon: 'W', x: -1, y: 0),
    (icon: 'N', x: 0, y: -1),
    (icon: 'S', x: 0, y: 1),
};

char InverseDirection(char x)
    => x switch
    {
        'E' => 'W',
        'W' => 'E',
        'S' => 'N',
        'N' => 'S',
        _ => throw new NotImplementedException()
    };

var distances = grid.ToDictionary(x => x, _ => (visited: false, distance: int.MaxValue));
distances[start] = (false, 0);

while (true)
{
    var (currentNode, (visited, distance)) = distances.Where(x => x.Value.distance < int.MaxValue && !x.Value.visited && x.Key.facing.HasValue).OrderBy(x => x.Value.distance).FirstOrDefault();
    if (currentNode == default) { break; }

    foreach (var direction in directions.Where(x => x.icon != InverseDirection(currentNode.facing.Value)))
    {
        var other = distances.SingleOrDefault(x => !x.Value.visited && x.Key.x == currentNode.x + direction.x && x.Key.y == currentNode.y + direction.y && (currentNode.facing.Value == x.Key.facing || x.Key.facing == null));
        if (other.Key == default) { continue; }
        var cost = direction.icon == currentNode.facing.Value ? 1 : 1001;
        var newTotal = distance + cost;
        var entry = distances[other.Key];
        entry.distance = Math.Min(distances[other.Key].distance, newTotal);
        distances[(other.Key.x, other.Key.y, direction.icon)] = entry;
        if (other.Key != target)
        {
            distances.Remove((other.Key.x, other.Key.y, null));
        }
    }
    distances[currentNode] = (true, distance);
}

var visitedSet = new HashSet<(short, short)>();
var toVisit = new HashSet<(short x, short y)>() { (target.Item1, target.Item2) };
while (true)
{
    if (!toVisit.Any()) { break; }
    var newToVisit = new HashSet<(short, short)>() { };
    foreach (var item in toVisit)
    {
        visitedSet.Add(item);
        var closestNeigbours = directions
            .Select(dir => distances.Where(dis => dis.Key.x == item.x + dir.x && dis.Key.y == item.y + dir.y).OrderBy(x => x.Value.distance).FirstOrDefault())
            .Where(x => x.Key != default)
            .Select(x => (item: (x.Key.x, x.Key.y), x.Value.distance))
            .Where(x => !visitedSet.Contains(x.item))
            .GroupBy(x => x.distance)
            .OrderBy(x => x.Key)
            .FirstOrDefault();
        if (closestNeigbours == null) { break; }
        foreach (var sub in closestNeigbours.Select(x => (x.item.x, x.item.y)))
        {
            newToVisit.Add(sub);
        }
    }
    toVisit = newToVisit;
}

timer.Stop();


var qqq = distances.Where(x => x.Key.x == target.Item1 && x.Key.y == target.Item2).ToList();
result = qqq.Min(x => x.Value.distance);
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();
