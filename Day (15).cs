﻿using System.Text;

var fullInput =
@"##################################################
#O##.OO.O........OO.#...OO#.......O..O.....O....O#
#OO......O..OOO.O#...O....O#.O#.O##...........OO.#
#....OO##O.O....OO.OO.OO...OO#..O.O.O.#.....#.O#.#
#..#..O.O#..O...OO..O..O.....OOO#.O........O.O#O.#
#O.#.#OO..#.......O.O..OOOO.O.....O.O............#
#........OO...O.#.O..O.....O.O.O.O...O..O....OOOO#
#.#OO..O....#..#.....O....#.OO....#..#.OO..O.O...#
#....OOO....O.......#.#OO.......O......OO..O#O.#O#
#...##.O....O..O.O..#..OO.O...O...O..OO....O#...##
##OO.O....O....O..OO....O....O##O.O..O.....#.OO..#
#..O........O..O...#.OOO.OO...O..#OO....O....O...#
#..........OO..O..#O.............#O.O#.#.O....O.O#
#...O.OO.......OO.........O.OOO...O.OO...OO..OO.O#
#.O..O.OO..#.....................O...O......O..O.#
##OO#.O.#...O.....OO..O.........O#....OO...O#....#
#.O.#..O.OOOO.O...O.O.OOOO..O...#......#O.O..OO.O#
#...OO....OOOO.OO.#.#O..O..OO.........O.O.......O#
#...#...#.O#....O.#O....O.O.O......OO..OO......O.#
#.O#.#O..#O...OO..O......O..O..O.O...O..O...O...O#
#.......O........OOO....O..#O#.....O#............#
#.OOOO......#........#...O..O..#......O..O.O..#..#
#OOO...O...O..OO.O..O.#O.......O....O#..#.O..O...#
#..O...##.O.OO#..O..O..O.....O...................#
##O......OO.O...OO#.O.#.@...O...O...........#..O.#
#O.O..OO.O..O......O.OO......OOO.....#..OOO..O...#
#....O....O.O.......#.O..O....#..#...O..O..O.OO.O#
#.......OO..O.....O..O#.O...OOO.O.O...OO#..O..O..#
#..#.#O.....OO..O.O..O......O#.OOOO...O.O.OO.O#..#
#..O.....O.#O#.....#O..OOO.OO.O.......O.O.O.O....#
#OO#O..##......O.O...O#.OO.....O....O.....O.#..O.#
#..#O....O..O.O#.#..#O.#O.#....#..O...#.O..OO.O..#
#OO.....#O....O.#O..O.OO..O.##O.O..O..O.OO.O.##..#
#O.OO.............O...O..#....O.O.OO....#O.OO...O#
#.....O#......O.O.O..O...O#O..O.#..OO.....#..O.O.#
#.OO..O.O..O....O#...#..OO.O.##.....O..#O..O...O.#
#O..O..#.#..#.....O....O.....O.##.#.......O......#
#O....O.....O..#.#OO.OO.#...........#.#.#O.....O##
#...O.....O..#......O.O.O.OO..O#.O#...OOO.OO..#..#
#....O.O.#O....#.......O.......#....O...O..O.....#
#.......O#....O..OOO.#OO..#...OO#....OO.OOO.....O#
#....#O.O.#OO.OO..O..O...#O.##.#O...O.#...O.O..O.#
#O.O...OOO.OO.#O.....O.........#OO.O....#.O......#
#.O.O.......O....OO......O..O.O.....O...O........#
#O#..#O#......#.O.......OO...............O....O#.#
#..O.OO.....O.O.O#O.O.OO.OO.O.....#O##..#O.#...O##
#..OO#.O..#.O.O.#O..O...O.#.#O..O....O....#O..O..#
#.O...O#.OO.......#.O..O...#.#OO.#..O.O...OO#O.O.#
#.....OO#....O....O.O...O..OOO......O....O#.....O#
##################################################

^^<>v^v^v>><<^<^<>>v>vv^<>^><v<><v^<vv<v^^<v^>^>><^>>>^<^v>^>v<^<<^>^<^v<^<v<<>^vvv^<^^v^v>^<><v>vvv<<<^><<^v^^^vv^v<vv>v<><><<v^v^>^v<<v^<><v>^>><vvv>v^vv<>>>><v^<>v>vv>v^>><>vv^^<v<<<<vv<><<^^<><<<^v><<^v^vvv^v<v>v^^vv^vv><<<<v>>v<^^<^vv<^^>v^^>^><^^v<^<v>^>v<^^^>>><<>><v^>^^>vv<>^^v>v><vvvv<<>v<^<v><v^<>^<><<^>^^vv><vv><<<<v>^<v><<<v<v><>>v^^<v<>vv>^v>v><>^vv^^<><>^vvv^vv^>^^v^^>>v<>>>^>><><>v>v<<^v^vv^<^vv>v<v<v^<^^v<^<vv>>v^v<vv^vv>^>><v>^>^<v^v>^<v^>>v^v^><v<v^><v><><^<>v^<^^^v<>>^v^^v^<>v><^<^v^^vv<><vv>^v^<>vvv<><>><^<^^<^^v>vv>>><vv^v><<<<v<vv^<<>^^v^v^><v>vv^>v^v<vv><><>^>^>>><>^^v^^<>v^v>>v^<>v<^>^^v>^<vv^>>v>v^vv<^>v>v>>^<><^^<^v<v<vv^<>^<^>^>>vv^<v><^v^>^^<v<<^>>^><>>^^<^^><<<<<^<^>>>^><>>v^^vv<>>^>><<<<>^>v^vv<v^<v<^><v>v^vv<^>^<<<<>>v<>^><<v><vv>^v^vv^v<><^>^v>v<^>vv^v><<^>>v^>v<^><<>>>v<<<<^<<vvv^^>><>^<>v>^vv>^<>^^^vv<><^>v<<^><v<<^^<<<^v<<^<><<^v<^v>^v>^>^v<><v^<<>v<^>><<^<<vvv<vv<<><<<<<^<>^^^<<>>v><vv^>v^v<^^v^^<v^<<>^v<vvv<>v^^<>v>v<><>vv<><^>><<><<><^>^v<^>v^<>>v^
>^<>v<>^^^><^^^^^>^v<^>v<v>^vvv<<<<^v^^<>^vv^<^>v>^^^v^v^<<<><^^v>^v<<>^v><^<>^><v>^v<vv<^<<^v<v><<<^<>^<<>>v<^<^^^^v>>>>v^^<^v>vvvv>v<v><v^^<><^vv<><<>^^vv<>^^^<^^v>v<<>><^^<<<<>^^v^^>><^^<v^>vv^>^v<v<>^^<>vv^vv^>^>v<v<<>><^<<>>vv<>^<^^>v^v^^vvv^<v<^v^>>v<<><^^v>>vv<>vv<^^v>^^>v^v^vvv><v>^<vvv^vv<<v>^^^^v>^<<>^^<v>>vv><<<>>vvv<^vvvv<>^<^<<v^^^^v<^<><<<^<^v<^v^^><<^>^v>v^<>^<<^<>>><>^v>^^<><^><v^<><v<^v>>^<<<<v>><>>^<^v<<v<><vvv^v^>>>v^^<>>>^v>>v^vvv<>><v>vv><><v^^^^v<^>v^<<>v<<v^<^<vv^^^^v^<vv<^<v><<<>>><v<v^^v>>^v<<v^<>^<^vv^^^<^<^v^v^^^^>v<vvvv<v^<^<>^v^>vv>v^>^<^>vv>^>^<^v>>v>^v<<v^v^><vvv^^^v>vv<>v><><^>>>v^v^^<v^<>vv^vv<>^>v>>^<v><<<v>v^^vv<<<v^^<v^^>v<v><^vv>>><^>^^<^^v^>>v>><vv><^<>>>>v>>^<v>^>^<^<>>>^<^^<<><<v<v^<^v>^v^>^>^>^^><>>vvvv^>>vv^><><<<<^vv<vv^vvv^<^vv^<^<v^^<<vv<^^><>>v>^<<^<><v<v^v^^<>^>v>^<^<v^<>v^^^v<v<^><^<><^>v><v><<vv<<v>>v<vv^<v<<>^v>>vv^<><<>>v><^v<^><<<v>>>^>v^><<^v<vv>^>>^>vv^^^^^>><vv>^<<v>>^>v^<<v<><<^^^vv^^v<^<v^v>><v^^<v>>^<>^>^<>v^^><><v<v^^v<v>>>^^vv
>><>^^^<>v^>v>v<vv^^<vv^<>^<><^^>^^<^^>^<>^><<>>^v<<<^^>v^<><<v<^>v^^<^^<><<vv>v><^<^^vvv^^>v^<v>>v^^>^v^vvv^v>^>v^><>^><>>^v>>v^<><<<<>><v>>^v<>^<>^>^^^>^^>^>v<^^^^>>><v^v<^^><^<^vvv>v^^>^^^v<^^<<v>><>^vvv^<^^v<^^>>vv^^<<^^^>v>><v>^v^v^v<>>>^v^<^<v>^v<^>v^^>vv<^vv>^><vv>v^v^^v^v<>^<>>^>^>v^<vv>>>>vv<<^^^<<<<^vv^>vvv^<v>^v>v^vvvv>>^^^>^^>>^<^><>><v>>v^v<<<^<vv^v<v<<v<>^<v>^>^^^v><>^<^<v^><>vv^<><>>^<<>^^>><><<v<>>vvv^vvv<^><><^^v^><>^^^>^v>^v<^vv><<v^^<vv>^^^>v^^<vv^><<^<vv>^^^^v><^<<v>><<^<^^><<<>v>v^^^^<^^^>^^>v^^^^^>v<>^>><^<><<<>^<v<vv>>^^^vv>v>>>^v<^>v><vv<<<<^<<^^<<<<v^<>^><vv<v<><<>><>>>>>>^<v>>^<<<><>>>^^v<v^<^<vv<<<vv<>v^<^v<<<^^<^^v<>^>>>^v^<><<v^^<v<^^><>^>v<<>vv^>>^v><<<<vvv^v>^<>>><^<>v>><^<<<v>v><v>vv^>^^<v^<>v>v^<>>vv<^v<>>><^><^^v^>>^>>v^v<v<v<^^><><<><v^^<<v^v<><vv^>>vvv^<>^v<^<vvv<v^<^^v^v<v><vvvv<><<^v>vv><^^v<<v>v>^<^><v>>^<v>>vv>>>><^<>v<<<^v<>>>^>>v<v<^<v^>^<v<^^<>v<<>^^><v><v>^<vvv^><>v>>v<<>v^v^<v^><>>>v>^><>><><v<^v<<>v<><<>^^><vv^<^v<>>vv<^>^^<>^^><^v^>vvv>^<<
^^>^v<><>>>>><<vvvv<>^><<v^v>v<<>v^<^>><>^<^v^><<<vv^^>v>vv<<><v<<<^^<<>>v>v^>^<<^><v<><><^>^<<>v><^v<v^>>v>^^^^>>^^^v<>>v<<v^v^^<v<><<v<<v<><<<>^<<>>v>^<>^^<><^<<v>>^^v^^<v<>^^<v>v<^^v<<v<<<<<vv<>^<v<>vv^v<v<<v^vvvv><^<vvvv<^>vv>v^v><<<>>^^vv<v^^vv<vv<>v^^<<v^<^><v^^^<<<>vvv<<<v>><^v>>><v><v<>^^<v^v>^><><^^>^>>v^^<>>v>v^>>><<^v>vvv^^v<^v^v<<v<v^^^^><><v>^vv<^v>v<vv^<<v<v<>>^<>^^>^v>^<^>>^<<v<v<vvv^>^>v<v^v^v^<v>v>><>^<<^<^<v^<<^<>^vvv^^<v<<^^><vvvv^>>^^v^v<^<>v><<^v^^>v>>>><<v>>vv><<^v^<v^>vvv<<>^^>^v<>><>^>^>v^^v^^<v<^>^<^v<>>^<<<^vv^>>><<v^v^>^<<<v<^^><^<v<^^^><^^<^v^<^^^<<<<<^v>^<>^<<v>>>^>^><<^><><v>>>v<>v>^v^v>^><vvv^v<^<<^v^<<>^vv^v^^>>>vv><^<>^^vv^>v<<^v><>^>^v<><<>>v^<<><^v>>>^vv><<>v<><^<v>>>^>^^vv<>v<<>v>^<<>>^^><v<v<^>v^v><vv><vv^v>>v^v<vv>><>>^<>^><<^vv^^>^vv^^v>>v><<v>vv<<v^>>^vvvv<<v><>><>>^><^><<vv<<><>v^^^v<<v^^><v>^<v^<v<<vvv<v<<<^vv<vv><v^>>vv^^<^^^>^<>v^^><>v<>^><<>^<><^>^<^v>v^v<<>><^v^<^>>v^^<v<^v<^v<v>><vv^>>^vv^^v><><<^v^v^^>^<<<>>>^>v<^<<<v^^^^>v>>vvvv>vv^<v<^>
<<v<>^^<v>vv<v<vv^v<>v^>vv><>^v<>>^<<^v>>>vv>^<><v^<vv<vv>>v^<<>>><<vvv>^^>vv>>vvvvv^v^<vv<>^<^<<^^<>>^^<^>v>v^<>>><<v^><^>>>vvv^<v^<^><^<<vv^^^<^v<^>><^^vv<<^>>>>>>><^v<^><<<><^<v^^^^^v<<<>^<>vvvv><^<vvv>>^<^<^^v>v>^^>^<^<<vv>v^<v>v^>^vv<v>>v^v^<^<v>vv><^<^>>v>v<<<><>^v>^^v^<<^>>v^^^><<<>>^^<v<v<><<^v^v^<>^^vv>vvv<v^>v<^^^v<v<><<^<>><v<>><v><^^<<^v^<v><>v<v^v<^^^>v>v<^>v>>>^>v<>>^>^<vv><^>>>^<<v^v>>^^^<<><>v^^^<v><vv^vv<^^vv<vv^>><v^^<<>v^v<>>v<vv^vv^<<>v<>vv^v>>^vvv^v>^^<v>v^^v>vv<>^^>v>v>>^><^<<>>v^v^>^^^<<vv>>>v<v>>>v<>^>v>^^^vvvv<v^^>>v><>v<<>^v>^^v>><>^>><v<v><v^>^<^<^<<^>v>^v<v<^>^^>^<<^v^<>>^^^v>vvvv<vvv>^^vvvvv^v<<>>><v>vv^<<<^^^^v<^>><>^>>>^^^^v^<<>>v>^^v^<>>><<<^>><v<^>vv<><<>>^v>v><<^v<>^v<^>>>>>^>>^v^>v^^<v^<>>^^vv^>^^^<>^^vv<<<v^v>>^<<vvv^>v<^^v<v>vv<><>>^^<>>>^vv^v^^<v<<v<v>>><>><^><>^>^^<><^>v<v<>^^><v<<<^^v>v^<>v^v><^<v><^v>>^<^>>^>vv<<v<<<^^>v>>^<>v^<^>>>v^^>>v<^^^>^v^<>vvvv<<^><v^vvv>>^^vv^^<v><>^>>><>v^>v<><v^^>>v>^><><<>vv<^<><><<v>^<v>><<>>^<^^^^>^vvv<^>><<^^<>^>>
>^v>>>^<^v^^<^><><vv<>vv>>vvv<^<^^v<^<v^<^v>>vvv<>v>v<<^^<><v<<v>^<v^v^vvv>v>v>vv<v>vv<^><^<^^<>vv>v>vv^><v<vvvvv^^<<>v^>>>^^^>><>>^^v><<>vvv<<v<<^^>>>^^><v>>v^^<^>v>v<>^vvv^>>^>>v<^<>v^<>^v<^<>^<<<<^v^v^<>^>v<v^>>^<>^<vv>^<>v><v<vv<><^v>>^<^>^<^<v>vv^v<><>vv^><^><<vv^>v><>v<v<v<<v<^vv<^^v>^<><v>>^<<^^^v<^v^<^v^vv<^><v^vvvvv^>^>v>^^>^><<>^>^v^<^^>><v<>v>v<>^v^>v^v^v<><<v<><^^<<<^>v<v^^^v^<v^^>>^>v>^>>>>^^>v<^vvv<<>^v^<><>^^><^v>v>^^^><><^v><><<>><vv>v^^><v<><<<v>>><>v^<^<^><<>v<v>^vvvvv>^v><<v<><<v>^<^><^<^v^<v><<<v>v<>^^v><^^>>v^<<<>>^vvv<<<<<^^v><<<><vvv^>vv<^v^v>^<v<>><v^^v^^>^v<<><<<><<>v<>>>^>>^^>^vv^<^v>vv><>^<<<<>><^<v^<^>vv<v>vvvvv<>vv^^^^vv^<<v><^<^<^>v^v^^^<>><><<<vv^^>>><vvvv<<<v<^><^v>^v^vv<><^v<<>^>v>^<<v><>>><>vvv><<v<>^>v><>v><v<<^v^>><^<<^><^><<<^<v<<>>v^>^<v<vv^v^v^<^v<v^>v<v^^>^v<<>vvv^^>>v>^^>v>>^<>>><<^^^<^>v>><<>v^<vv^>^<<v^>v^><>^>^^v>v^^<>^^>vv>vv<<v<^<<^<<^^>^<>^^vv^><<<vv^v<^v<>><<<<^>^><>>^vv>^v^v<vv^<<v^^>^><v^>>^><^^>^^<^^v^vv<><^>v>vv<vv<<<>^^<v>^><vv^>>>>v
v<<^v>>vv^<><>>v><>vvv<>>v>^>>>^<>^vvv>^>^^>><v>^^<v<<v<><>vv^>^^<><>>^<vvv^vvvv<^<^v>^>>^>>v>^^v>v<>>><v><<<<vv><^v^<<^vv<v><<^>^>v^>^^v<><vv<^v^>v<^v^^<>><^>><^<<<^v^^^v<<^<>>v<^>v>^>v^v^^^^v<^<<v^^<<^<><v>^^v<v^<<<^<<vvv><v<<>^vv^v>v^^^>v><><^^^v><>^>^>^>><v^<<><^^<v<v^>^>v<<<<<<<>vv<<vvvv^vv<<<v<><<^>v><^><^>v^v^vv>vv<^><^><<^<^<>v>^v^^>><v><>^v<vv>>>^^<^v^>v<><<>>^v^^^v^^vvvv^>v<><v><^^^^>^<<v>>>vv^^^^<v><vv<^>v^<>v<<v<<>^v>>><<v^<>v>v<<^v^v^>^><v^<>^v<v<<^^^>^^>^<^<><>^v<><^^>^<<^^^<^>^>vv>^^^>^<<>v<v^<^>v^>><<>vv<<<>vvv^v^v<><^^^v<^^>^v^v><<<^>^vv>v^^vv<v>^<^>><v>^>vv^<>v^>v>>><vv<^^v<v>v>^vv>^^vvv<^<vvv^>>^<vvv^<v<<^>v<><>v^v><><^>^><<<>^><>>^^<<<^>>><<^v><v>^^>>>v>^v^v^>v<v^<<^<^vv^^>>^^^^<>>>v^v^^^>^^>^>v^vvv>vvvvvv>v^^v>^^>^vvv^<vv><>^vv>^vv<v^^<><<>^^<v>>>><<v>v^^^v>v><v<v<>v><<vv^<v<<^<<<^>^v<>v<v>><<v^>v^<>^>v<^>^^>v^<v><vv>vv^<v<^<>><^<^<>^v^<<<<^<>><v<<^>>><<<v>>>>>v><<><v>^^<><^>v<<^>^^^<^v>v><v>v>^^v<>v>>^^>v<>^^^vv>><^>^>vvv>>^><<^v><<^^<^^^^^^v^v>^>^>v^v><v^<>^>>v>>
>^><><<>^<>^^<^^^vv><>^^>vvv^>vvv<v^>><<v<<v<vvv<vv><^v^^v><<>>^<<<<^<v>^vv<^><v>>><v^^vvv>v^v>>^vvvv>><<^vv^^>^>^<^v>^v><<v^><^^v>>><v<<>^v><v<><<><v<^^>>>>^<^^^^^^>^^<^v^v>>^^^<>^><<>^>v>>vv^^vv<<>v>>^^^v^v^^^><>v<^^^v<><>>vv>^<^^><v>^^^vv>^^vvvv^<>>>^^^><^v<>v^^<vv<<v>v>^>v><><<>>vv<><<>vvvv^>v^v<^^vv<v^>v<><<<<^vv>><>v<>><^<<^<^^^vvv^<><<^v>v^><v><^^><<v^>v<v<>^>v><vvv<^<>>^>v^v<v>v<<<vv><<v<^v<<>vv<vv>^<v>><v^v^v^>v<<^v^^^><v<v^v<v^<>>>>vv>>>v^>v<v>^v<vv<^>^<^^^v>vv>vv>><<>>>^<^>^<<^<^<vv<>><>vvv>^^<v><v^v<<^<>vv<>v>v>v^>>^<^vv<vvvv^>>>v>v^^v<v<<>>>^^<>^><^>>>^><^v<v<v<^<<^><<<<<<v>>^<><<<><^>vv^^>v>^>vvvvv^>>><<^><^<^^>><>v^<^v>^<>v^v^v>>v<<^v><>v>v<v<^vv>^v<^v>vv>v>^<><>vvv^<<v^^^^v^>^^<v>^<>vv^><>v^>>^<vv<^^v>v^<^vv><>v<<^><^>^v>vv>>>>^^^<<>>v>>^^v<>>><<^v<v><v>><<^>^<v<>v^^<^><<><>>><v<v^^vv<<^>^v^<<>>^>v><>>^^>^^v>>^<>v^<<v^>v<v>^^^v>>^v^<>^<^><>^<vv>>^<^><>v>vv>v^<><v<<v<<<^^^>>v^^vv^v><>>>>>>>v>v<v>v^><v^<v^^>vv^^><<^<^^<v^^<><>>v>v<v^vv^><<^<><^<v<<^v<v>>><<^<v<v>><^>v^<>^
>^v<^^^^<v>vv<>>v^v>v<<>v^<>vv<<<>^v<<><v<v>>v^v^><v><^>>v<v>v^v<vvv^>><<v<<<<v^^><><^^>^><<v^^^v>^^<<>^>^^<<<^>>><v<><>>>^vv>>^v<<v^<>v^>^<^^^^<vv^<<>^vv<><>^^>vvv<>v<v^^v^>^^><^<>><v<v><>v>v^vv>^v>^>v><><v<<vvv<>^>v><>>^<>v^^^^><v^<<<><v>v^^>^>>^>^v<>v<>^^^v^><<<<v<<^>v<<><v>>v^>v^^>>^>>^^><v<^^v>>>v<>^v<v<<<v<>v^<><v<<<<^^vv<^><<>v^<<v>v^vv<<v^<vv><v^^^>vv^v^>v><<^>>>^>^v<>v^<^vv<>><^^v<>vv>v<<^>>^v>v^<^v>vv^^^vvvvv><>^<v>v><><^^vv^^>^><>>v>v^<^vvv><<v<<vv>vv<<v^^<>^>><v^v<v>>><<<v<^^^<<^<>vv^>>>v><>>vv^<v^^>^v>^<v^v>^^>^^^^>v^^><><<^<^><^v><><<^^><vv<v><<^vv<>v<>>v^v>><<v><<^><<^^^v>v>>>v^^<^^v>>>v>>>^<<vvv^><<v<>v^><^>^<<v><<<^^>^>v^<v>^vv<^^<<<<>^^^^<<>>^^<v^^v>^>vv^vv^><^v<^>><><^<v^^^v^vvv^<vv>v^^>v^^>v<>v<v^^>>v^<vvv^^^<>><^>>><<<<v^^<>v^v<v>^<<v>v<^<v^>v>^<<<><<v^>>>^>>v<>>v^<v>v<v>>v>^^vv<>^vv^^v>v<<v^^<<v<vv>^v<>><v>^><<<^<><>>vv^^vvv^v^<^v><>^^<<<>vvv<>v>^^><v<vv<<v<>^v<v<^^>^v>^v>>><>^>v<vv^v^><>^>^v>v^^v^^>^<<>>^<<<<><<vvvv><><<>>v>^v>>>^v>>v^<>v<vv<^^^<>v^>v<>v^^<^v<v^<
<<><v><^<><<><<vv^<<>>>v><v<v>>^<<^v>^<^vvv^v^>><>><>vv<^<vv^v<^><^vvv>>^>v<>^^^v^><<^<^^^<v><>vv<^>^>^>^><^><<^>><>>v<><>vvv^v^^<<<>^>v>^>^<v^v^^<^v^vvv<vv^^v^>^^>vv<^vv^^^>>><^<>><>><<>v><^vv<<<<^<<v<<^<<>>^^>^>>^^<v<<^<^^>v>^v^>v^<^>>>v^<v^><^vv>^^>>^<>>>^>v^<<>>>><><<>>>^>>^>>v^<^vv<<v>>>>v><><v<^v<<><v<>v^><v<v^<<>^<v><^^>v<>^>>v<v>vvv><><v<<>>v<>^v>^^<<><v<<>vvv><<<^>><><<vvv><><vvv^>^>^v<<><vv><<<<v>vv^>^v<v<<^v>v<^<<vv^v>>><^^>^vv<vv^>^vv<v<>^><>v<<<^^<<^^^^>><>>><>>^v<<v>v<v^<<^<^<<<v^v><<^><^<<v^v^>>^^<^><<v^^^^vv^v^<v>v><<<vv^>^v>>v<^><<>vv>vv<<v>vv^>>v>>><^v^^v<v^v>v^^<^>v<>vv^>^<<v^>>v>^>^>><>>><v^^>^>v^v<<^<^^<<^>^<><<>><>^>v<^^<<>^<v>v<^v^^v<<^^>v>><vv<v<v><v>v<^<^>^>^><>vv><<^<v<v>^vv<>>v^><>><<<>v>vv><v>>v^>^<<^^><>v^>>><^>>>>v^v<v>^v^<vv^^^<<<^<<^^<>v^^<<v>>>v<vvvv<<^v>vv<vv<v<v>>v>^vv>>^v><>vv>v^v<^^><<<^<^>>v<v<^<<>^^vv>^v<<v>^^<><>>v><^><>^^<v><^<><<>>v><^<^><^v>^<v<^>^v<vv<^v<><<vv<>v<>><<^^v<^v<>v^^>v^^^vvv>>>>><>>v>^v<>>><>>^>^vvv><v^><vvv>><>v>vvvv^<v<vv<v<v><>
v<><<<^<>^^^v^<<>v<<><><^>^vv^v<^v<<><^>v><v<^<v><^<vv<^^><^>>>><>^^<^<v><v>vv><v<>>^<<vvv<<^^^vvv^^v<^^^v<<^<v>^>^<><v<v<>>vv^v^>^^<>^>>v<vv<<v<>v<>><^>vv<v<<>><^>><^^<<v<v<><>v>><v^v<>>^v>><v^^^^v<v>>vv<v<>>vv>^v<>^^vv><^v>v<v><^v^^v^v>^^^>><<<^<vv^^v<<>v<^<v<<>>v<>>^>v^^>^><><^<>v^<v^<<^v><v^>^vv>^v>vv><^<>^vv>^<>>>v<^>v>v^<^>^><<<>>^>^<^v>>v<<^<v>>>>v>v^^>vv<v>>>><<<^v^<<v<vvv<v<^^>^^^^^v>^v^>^vv<<<^^^>^v>^>^><v<v^^>^>^v^><<<v><<><vvv>vv><v>vvv<^v>>^>vv><<<v<v<^>v^^<v>^^<^vv^<><<<<v<vv>^v>^<vvvvvv>>^^<^<>v^><^v>v<<<^<><v>>^v>v>>v^>><^<v^><<^^^><^>v^v>vv^>v>v^v<<^v<<><^<v^^<v^v<v>^<^vv^>>v^^v^<^v^<>v<^^v>v^v^^^<^v>>v>><<^<v^vv>>^v^<<<>^<v>v<vv^>^>^v>v<<<<<<>><vv^^vvv><<>vv^^v<v<^vv>v>vv<v>v^^v<>v>^v>vv<<<^>>v>^><>^^<vv>vv>v<>v<^<v>>v^<<^^<^v<v<^<^><v<vv>^vv<<^^<^>><><^<^v>^<vv<v^vv<^>vv^vvv<>^>>^^^>^>^>^><^><><><^v>v<>^v<<<>v>^>>v^vvvv>vv<^v><^><v>>^>>>v^^^v^v>^<^<<v<^<<<><<>>>v>^>>><>><<vvv<v^<>v^<^<<^^<>v^v>^^^^v<v><^<<>^<^v^vv^>>^<>v>>>vv><<>><>^v^>v>^^^vv>>^^vv>v>>v^^>v<<><>v<<>
<>><>v^^v<<vvvvv^v>v^^><<^^>^>^^v>><<>v^<^^^><><>v^v<v^^<v^><>vv>^<^>^^^v^<<v><><>vv><<v>^v><v>>^>^>^^<<v>^>^^^vv>^<><>><<<vvvv>>><vv>^^<v<v>>^><<^^<<^<<><^vv>^^v>^<>v>^><v^v^v<<<v<^^<<><>v^vv<>>><^vv^^v^vv<<^>vvv>v><^v><^v^^<^<^<>^^>>^v^><<<<>^^<<<vvvv^>>><>>>>v<>>^<>>v^>^<^^v>>^>v^^<^>><><><^v^v>v<^^>^>vv^v>v>v<v>^<>>v>><>^<>>v^^vv^<>><<^><^vv>>^><<v^^><><<>^^<<<<^^<v<>v^<^<>>v>^vv<vv^<<^^<>vvv<^v<<v^vv^vvvv<^v<>v^^^>v<<v<v^>>>^^>^v^<^>v<^>v^vv>^><<v<^^>^^<>><^v^<><<<^><>><^<<><^<><vvvv>v^>><>>vv>>^>vvv>><>>vv<^<v^>>^>^v<<^^<<^>^>v^<<^<^><>^v<^<<><^v^<<v><^>>v<<^><>v^><<>vv<^><<^vv>v<<<v^v><^<vv>>^>>^>><^vv<<^<><>>^<vv^><vv^v>>^^<^<^v^v><v><v>^<^vv>v<^><<<><<v>v^<<<^<<^><v<>^vvv^v^v>v^>v<v^v<^^<^>^^v>>v>v^<>vv<vv<><v<>^v<v^<>^>^v<v>>v^^^<v^^v^<>v^^v>^><^<^<<v^<<^<<vv>>v<^>^^<^>>>^<>vv<v>v^><<<v>v^>^><>>><^>v<<^<v<>v>><<>^<v>><^^v<v>v>vv^>v<^^<<<>>^v^^>^^<<v^v>>vv^><^^v>^>^<<v^>^^>vv^>vv^><^><<<vv><>v>^^^^>>^<>v>>v>><^^>v^vvvv^^>>vv^<v^^><vv>>v><>^^^<^^<<>vv^>v<<>v><>>><^vvvv^>^<>v^v<
v^vv<^v>^<<<>^vv^<^>v^>v>>>^^>>^<>v><<^<>><^^>v<v>^v^>>v^>>><><<><v><<><<v^v<>^v<<vv><<vv^^><>>vvv><>><>v<v^<v^>>^><><>^v<vv<>vvv>v>v<<><>>>^<>>^>v>>>>^<^^><<vvv<vv<^v<v<v<v>v^^><>vv>>^^><><><<^v<^<>>>^vv<<>^>^><^<v>^<v^<<^>>>v<>v<>v^^>v<vv<>>^>^>><v<<<>v><v>^><vvv<v^>v^>v><^vv><<<^^<<^<^<v^>^<^vv^<>>v<><>^<<><^^>^><v>v^vv^^<<<>v>v>^<<v>v>>v^<<>^>v^<^<><<^<>^v<v><v^>^vvv^><<vv^vvvvv^<>>^<^^v>>^v<<>>v<^>^^><vvv<v^v^<^v^<<<v<<><v^<<v<^v<v^>^>^<^<>^><<^^>vv<^<^v^v<><^^^v^^<><<^^>v>^<<^>>>>v>v^<>>>vvv>>v^<>^<vv^><v>><<<>>v<^<v>^<<>vv^<>vvv<>v><>v<v^>^^v>v^>v<>vvv>>><^vv<>^>><<<><^>^^<<^^^>>vvvvv^>^^><<<vv<^vv<<^<<>v><^><><>vv^vv^v>vv^v><^><><>v<^^v^v<><>^v<vv<v<^>^><>^^>>vv<>>vv>vv^<v^>^v>^<vvv>>v^v><>v<v>^<^<^vv>^v<><v<<<<vv>^^>^>v^<<<^>^^^<<v>>vvv>>v^>><^^^>>>v^^<><>v><>v<v^vv^><<<^^><^vv^^v^>><<^<>>>v^^>^<v<>>>vv^<^<vv^^<v>>vv>^vv^vv<^>>>v><v>^>^>^vv>>><>v<<^><<^>><>v^v>v<>^v^^>v<vv>v><>v>^><<<>v^<vvv>^<>><^^<vvvvvvv^v<<v^^<>^vv<>v^vv<>^><^^>^^>^<^>>>vvv<^^^v<<^<<><>^>vv<>^<<>>v>>^>vv>v
^<>v<>v><v<>v^<>v^^^^vvvvv<v>^v>vv^v^v^^v^^^^>v^v^>>v<>v^^<v><>>^<^^<vv>^>v<^>vvv><v^v^vv^>>^<<>>>^<>^v><v>^^v^><<<<v<v^v^^<>v^<>>v>v^>^>>><^>vv<>v<<>v^>>vv>v>^>><^><v<><^v^><^^<^>>^<^<v^>>v^<<>><>>><v^<>>v<vv>vv<>^v^vvv<vvv^<v<^>^v<>^v^^^^>>>v<v^<><v>v<>>v^>v>v><<<^^>>>v<^v^<<^v^<vv><<><>^v^^>^vv<>v^>v>^^<^v<^<^vv<><v^^<^>v^vv<<<<>>^v^<v<<>>v<vv<<^vv>^^>^^^<<<^<><vv^vv^>v>^vv<v>v<^^<vv^><>>v<vvvv^>^>>^^^<>><^^^<v<>^v>>>^>v^v^v<v>vv>^v<>^><<>>^v^<v<<>^>^<<^v<<v^v^v^^><v^^v>>>v>^vv<^<v<>vv^v^><^^^<><<^<>^^>^vv><<<<<^v^<^v<>vvv^v><vv<<>v^><v^>v>v^v^<>^^<>v>v^v<<><<<>^^v^>^v>v^^<<<vv>^v^>>^v<>>><v<vv^<>><^^<<v<>^^^<>>vv>^^v>^v<^>><>v>^<<<v^v>vv<^<<v<^^>v<v<vv^^v<><>^v^^<v^^<^vv^<v><^vv<^<vv^>>>^vvv<><^<^>v>^vv<<vv><<>^^>v>>^v<v>><^^vv^>^vvvv^v^<^>v<>^><^^^<<vv>>>v><><>^v<^v^^>^<v^<>vv<vv><>vv>>>>><<<<v><><>>^<^<<<>vvv<<<<>><>v^v>>^<>vv<^v^vv^^^v>>vv>^>^<^<<v^v>vvvv^vv^^>>^v^>^v><><vv><^<>v<>>v^^>^<v^>><v^<v>><>^^<vv^<<><>>vvv^v^>>^^<<^<<<^<>v^^^^^<<^>^^<>><><v>>><v^v<^>>^<>>>>>>v^vv<^>><v
v^>>>v<<v<<>>^v>>v<<>^^v<>v^^v<^>><>>^^>v^^<^>vvv>vv>v^v^>^>>v^>vv^>v<<vvvv>vvv>v<v<><^><v<>^v>><>v^<<>v^<v^^^<v>^^>><^><>^<^>>^v><vvv<<>^v<v>^<^><v<<^v<^<<<^^v<<<<<<^><>>>>^v>v<>^>^^<^<<>>^^^^<v>v>^>vvv<<<v>>^>v<<^^^vv>>>v><^^v<>>v^<v<^><v<<<vv^<vv<^^^^^v<^^>v^>>>^^^><<^^<<>>><<<<v<^^<v<^^<<>><<>v<>>^<><<<^>><>><<v<>><v>^v>^v<<<><v^<>^^v<<^v><vv^>v>>^^^v^^^vv^vv>^v^v^^^v<^>v<<<v^<^vvv<><vv>vv<>vv^^><v>>>>><<v<v>v>v^v<>>^><<<^<<>>^^<<>^^vv<^>>^>>>>><v<v>><v^vv<v^<<v<>v>v>>^>^^^><vvv>>^<<^^>>v<<^<<<v^v^v^^>v>^^<><^<><v><><><vv><v^v<^<^>^^v<>>><^<^<^<^v<^^v><^<^>v<>^<><^>^>>^^^v<vvv^<>vv^^>^>^<vv>^^>^>v><^><v<v<v^vv>^>^^v^>^<^><>><<v<>v^v<><<v^^>v<>vvv^^^<v<><<>^^^v^<<vv^v>>>v^<^><vv^<>^<>^<><>^^<><<v^vv>vv><<<v^<v<<>v>^^>v^>vv<>^<v<^vvv^>>vv>^>>^>^<^vv>>vvvv>vv^<^<v>>>^vv>vvv>^>v><vv^>v<<><vv>><>v<v<>v<<v>^<^><^^>^<vvv>><^v><^>>v<<v<v<<^><^>>vv<^>v>><^v^<>v><^^<><v^>^vv<<>>><><<>^><vv<^<>v^^<^^v^>^><^<^><>^<>>>>^>>vv>>vv^<<^vv>v^<^v><<>vvv>v>>vv>^^^<^v<<<>v<><>>vvv^<><vvv>>>^^><v<^>v<^^
v>^^>v<<>^<<<^^^^^>v><>^>>^<v><<<>>v<^><<^<<vv<vv<v^^v<>>>>^v<v>>v^^^^v<>^vvv><v>vv<v<v<<>v><>^^vv><<^v>v^>vvv><>><><^^vvv<v^<v^^><v>>>>^^><^^^<v^>>>><>vv<<>vv<>v^v<v>vv><<^^v^>v<><v^<^^vv<^<^^>v>v<v<vv^<<><v^v><vv^>^^vv^v>>>vv<^vv><vv><^><v<<^>^^^>>v^<v^<<^^^v^<<^<^^^^><<<vv<vv^>^vv^>><<v<>^vv>v^v<>><<>vv^>v>v^>><<v^>^^<v<^v<^vv>>v^^^>^v<^^v<v>^><vv>v^^^<^^^^<^><>vv<>^^>vv^v^><^^><v>^^vvv<>^^>v^v^<^^><>>>^^v^<^^v>vvv>^vvv<^vv>v<v^v><vv^>vv<<><>>^><>^<^>v<<<<><^v>>>v>v^^v><><v<^<<>^v<vv<<<v<v<^^^^<^^^<>v<<><><<<<<<^^><<<v<>^<<vv^^><<>^v>^><>>vv^>><<v<><>>>vv>vv<<vv<v>^<<^<^>v<<v<><<>^<<v^<vvv<^v><^<<<<>>>><^^<^^<^>>v>^^^>v<<^vv<^^vv<<v<<v>v<^><^vv^^>vv^<v><vv^v<>v^<^^^v>>>>vvvv<^v<<<<v<>^<v<<v>>v<v^<><^<>>^>^<>^<>vv<<><>^><<vv<>>vv<<>^^^vv>v^<<^v<<<>><vv<<<v^<v<v^^>>v<v^v<^<<><><v<v><<<v<>><><<>>^><><<<>^>>>^<<^<^^v<v^^><>>v<vv>>>v<<^><><<^^v>v<^<^<<>v<v>^v^v><>>vv<<^v^v<>v><^<<v^^^><<^vv>^>><^vvv>^<<<^v>^>>v<<<^v<^>^v<<^v^<vv<v>^<v^v>^^^v^><<>^vv^^^v<<v<v<v<v^<<v>>vv>>^<>>^<>v^>>^v^><
^^<v<v<<v>>v<^^vv<><^^<>^<v>v<^>><^^<><>^><^<^v<v^^^^v^>^^v<^>^v>v>vv>^^>v>v>^^^^v>v^v^v>^><v>>^^^>>v<^<>^^v<v^^>v<^^>><>>^vvv>^vvv>vv<<v><^v^<v<>>>^^^v^<<^>>^^v^^>v^^>^>^<v>^><>v>v<<v<>>v^^v<v^^>^>^<>><>><v^v^^^<>>^^>><<^>><<v>><<>>>>^^>>^v><^<>^>vv^v<><^^<^>^v<v^<<v^v^v>><^<vvv>^>^<<<<<^^v<^>>^><>>v>>>vvv>vvv><v<^^v>^v<<<^vv^^vv^<^^v><^<>^v<^^v^<v^><>v>^^^^>>>v>^>^^v<^<<>^<v^>><v<^v<vvv><>^><v>><>v>v>^<><>^v^<<^<<^<>v<^<v><v>^^v^<><>>v>v^<<<v>v<vv><v>v>><v<<>vv^>>v><<^^>>^^>>^^^v<<^v><>v^^v<^vv^>v<<>v><<<>^v>v<v^^<<^><v><>^^^^>>v>>vv<^v>>v^v<<<v<<^vvv^>><>v>v<>^<^v<>>>>^^^<>v<<<<^>vvv^><^<vvvv<<>v<v^<>^^<v>>^^>>^>><^vvv>v^^<<>><v<vv<v><^<v>v<v^<>v^vv^<>^>>^<>><^^^>^<>v>^vvv>>>>v^vv><<vv<v>^<<<>v<>>^>><v^v^v^<vv^<>^>v>^^v>^^>^v^^<^>^<><^<<<^^^vv>^<vvvv>>>v^><<><><<<^^<v<^^<^>>^>^^>vv<^^vvv<<>^>>><<v^^v>^vv<>>v<<<v^<>><<>><v^><>v>>^>^vv>><^v>v^v<v<v^^vv^<v<><vv<v>>vv><<<<<<v^v<<vvv<^^>>^><<<>^<^^<vv^>v^v<^^>>><<>>^v^>^^vv>^<>><v<^v><<<^v<<>vv>^vv^v^^>>^^^^<>v<>v>>^>>>>^>>>v^v>><<<<>v<^
>^>^<^v^<><v><<<<^><>^^<>>vv^v<^v>v<><<<^><^><^<v><^^<<>vv^<<<v^<>v^<^v<^<^vv<^<^^<<>>v><v>>^>>>^<^^<vvv>><vv^>v>v><<^v>>v>><><vv<>^<<>>vv^^^<v>><^<<v^>v<^<>v><vv<>v>^>><vv<>^^<^><><<<^>vv>>>><v<^v^<>><>vv<>^>^><<<><<v>v^>>><^v^^^<vv><<<>>v^><^><^>^<<^<<>^^^<<v<<v^<>v>^>>vv<<<^^^<<>><^<v^v<<^<<<<>^<^vv<><<^<>>^>>^^>^<<^vv<<v><<>>>^^^vv<v<<<^<^v>>v^>>>^v<^^>^>>>^v^vvv^<<>>><>><>v>^v>>v<^^><>><>>><<<vvv>^<v^v<^<^<v<<vv>^<vv>^<v>>v^<><^^<>><<v>v>><^v^>>>^>v<v<^<><vv^>^v>^^><<v<>>>v<>v>v^>v><v^<^v>>^^v>v<vv<v^v<>v^vv^v>^>vvv<>v>v<^vv>v^^^>^<v^^<^><v>v^><v<^>^v<>v>^v>^>><>><^<^>><^v<<><^>^v<>^v>v<v><^^v<<^v<^^^v<^<<><>v<>v^><>^^v<>^<vv<>vv^^<^^v<^<><<<^^><v>><vvv^^^v^v>>>^<>vvvv>^>vv^<><<v>><^v>v^^><<<v>><>^^<<^<>^^^^^<<<^><>^v^<v^v<<<<v^^<>^<<v<^<>v>><<^>^v^<^^<v^<<v^v<>^^v<v^v<^vv^^<>>v<<<^<><vv>v<^v>^>^^>v<^^>v>>><>v<<^^^v>^<>>><<>>^>>^<^^^<<^<<<vv>>vv^<^<v><<^vv^<<<v>v^^v<v>^<>^^^v<>v>vvv>^>^v<<>>^^^vv^>^>v^>>vv<<^>>vv<v>v>>>v<<^v><>^<<<>^v^vv^^vv><v^^<<>^^^v^^<^<v^^^<^v>vv>^>^<>v^>v^<>
^><<^^vvv><vv<v<^^><v<<<^<>v>v<^vvv<<<<>><<^>><<<>>><>v^>v^>>^vv<<>^>>>>^>>^><>^v><<>^^>^v><<^^vv><<v^v^<>^^v>v<^v^^^<^<^v>v<>>^>v^^<<>>v>>^^><^<^>^v^>vvvv>^v^vv>>v>v>^<^^>v^^<>>>^>v>^<>^<<^>^>^><><>^><>vv>><<>>>^v^^^<>^>>v^><^<v>vv^^<><<<v<<>^<>^<v><^^v>v^v^>>^<^v<v<<<<>^><<<vv><<<^>vv>v^^^^<^^^v><>v<>v>vv<v>>>><vvvv^<^^^<v<>><<^^<>v<<><>v<^>>v<>>^><<^v>v<><v<<<>><v^><^v^>^<<v^>v^v>><^^^<^<><>v<^^v>^v^<<<<^v<<^^^^v>v>^v^^<^vv<v<<<^>^v<<^>^>v<>^^^<<><v><>^v<><^<^<v<^v><v><^>v>^v<>^vv>^<v<^<vv>^^>vv<><>^<v^^>v<><<>v^v>><>>^<^^<^^^>^v^vv^vv^^<v<>^v>v><^vv^>>vv^<<v^^v>>>^<^v<>>^^^<><^v<vv>^<<<vv^^^<v>^^>vv^v><<v<<^v<v^><<^>v^^^<><>v^^v><v^^^v<^<>v><^<^v<^^^^v^^><>v<^^<v>^^<<^v<<v^v>v>v><>>^><^^vv^vv^<v>v<>vvvvvv><>>v<>^<v^>^>^v^>vv^<v<<^v<>^^^>^<><>^<<<>><>^v^<v^^<>vv<>^^<^^vvv^vv^v^^>><>^vvv><^vv>>>^>^>>>v<vvv><^>v^^^v<<>v<^v^<>^<^>>><<<>>vv^v>^v^v<^^>v^^>vv<^>vv^<^^>^^v><v<><v>>>>v>v^^^^^>^^v<^^>vvv<>^><>^^vv>v<vv^^><>v^^v>^^^>>v>>><>v>v<v<^>v^^<^^v^>v^^>v<^v^<vv>>>^vv>vv<<^<^vvvv<><>><
>v^v^<v^>^^^<^^v^<><v<v<<<vv<^^<^^^><v<>>v^>v<^<v^v^v<>v<^><^^v<v<vv^<<>>v<v><v^<>v<v><^^>vv><v^<>v>vv^><vv><>^<>>v<^^<>^^>v>v^^>vvvv<><>>v<<^><<^<<>>^<^^v^<^^vvv<v>^^>^>^>>v<v<v^<^><^^v<vv^<v<vv^>v<vv^^<^^<^^<<v>>^>^<>^><>v^v<<>>>^v^^vv><^<<<>v>^^<v^v<^v>>vvvv<<^vv^>^vv>^^>^<<><><>^>^<><><>^<><^^^v^>v<<>vv>v^^v><v^v>>>^v<^^v^vv>v>^>>^<>^>v<v^<^<v<>>v<<v^^>^v<v<^vv>^^v>^^<>v>v<^><v>v>><<<vvv>vv>^>^<^><>v><<>>^^<^v>v>v^v<<><v>v^v<vv^>^<<>>v<v^^<>>>vvv^><v>vv^v<>v^>v<v>><<>v<vv>vvvv^>>><>>v^><^<>>>v^v><^>>>^^>v^>^>v>><<>><<<>vv<^v><>^><vv><^<>v<<v>vvvvvv>>^^<>><>vv>v<vv>^v<>>v^^v^>v>><<^>v<^<v^v>v>>>>^><vv<^v<^^<vv<v^>^v<v^<v^vv^v<<>v<^<v^<<<<v^^><^v<<<v<^><v>v>vv<>>>vv<^>><^>>^<<>v<^>>><><^<><><>>>>>^>>v><^<v<<v^<<v<<>v^<^^^><v><vvv^>^>>^^^v<^>^<v<>><^>>>><^^^<^>^<v^^vv^>^v^<<v><>>^^<^><<^<^<<v<v>^>^>vv>>vv^^^^^>vvv^vv<^^<^>vv><>v>^<^^^v^><^v><^vvv<vv><^<v<v>^vv^<v><vvv<<<<v><>^<<v<^>vv^v>v<v^v^^vv^vv><<>>>>^>>^<v^vv>vvv>>^vv><^^><^<v<<v^^v^<v<<^>>^^>>v>^v>v<<<>><v><^v^>>>^>^><<v^>vvv<>";

var smallInput =
@"##########
#..O..O.O#
#......O.#
#.OO..O.O#
#..O@..O.#
#O#..O...#
#O..O..O.#
#.OO.O.OO#
#....O...#
##########

<vv>^<v^>v>^vv^v>v<>v^v<v<^vv<<<^><<><>>v<vvv<>^v^>^<<<><<v<<<v^vv^v>^
vvv<<^>^v^^><<>>><>^<<><^vv^^<>vvv<>><^^v>^>vv<>v<<<<v<^v>^<^^>>>^<v<v
><>vv>v^v^<>><>>>><^^>vv>v<^^^>>v^v^<^^>v^^>v^<^v>v<>>v^v^<v>v^^<^^vv<
<<v<^>>^^^^>>>v^<>vvv^><v<<<>^^^vv^<vvv>^>v<^^^^v<>^>vvvv><>>v^<<^^^^^
^><^><>>><>^^<<^^v>>><^<v>^<vv>>v>>>^v><>^v><<<<v>>v<v<v>vvv>^<><<>^><
^>><>^v<><^vvv<^^<><v<<<<<><^v<<<><<<^^<v<^^^><^>>^<v^><<<^>>^v<v^v<v^
>^>>^v>vv>^<<^v<>><<><<v<<v><>v<^vv<<<>^^v^>^^>>><<^v>>v^v><^^>>^<>vv^
<><^^>^^^<><vvvvv^v<v<<>^v<v>v<<^><<><<><<<^^<<<^<<>><<><^^^>^^<>^>v<>
^^>vv<^v^v<vv>^<><v<^v>^^^>>>^^vvv^>vvv<>>>^<^>>>>>^<<^v>^vvv<>^<><<v>
v^^>>><<^^<>>^v^<v^vv<>v^<<>^<^v^v><^<<<><<^<v><v<>vv>>v><v^<vv<>v^<<^";

var smallest =
@"####################
##[].......[].[][]##
##[]...........[].##
##[]........[][][]##
##[]......[]....[]##
##..##......[]....##
##..[]............##
##..@......[].[][]##
##......[][]..[]..##
####################

>";

//smallest =
//@"########
//#....OO#
//##.....#
//#.....O#
//#.#O@..#
//#...O..#
//#...O..#
//########

//<";

//smallest =
//@"##############
//##......##..##
//##..........##
//##...[][]...##
//##....[]....##
//##....@.....##
//##############

//^";

var input = smallInput;
input = fullInput;
//input = smallest;

input = input.Replace("#", "##").Replace("O", "[]").Replace(".", "..").Replace("@", "@.");
bool print = true;
print = false;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0l;
var inputSplit = input.Split(Environment.NewLine);
var gridPart = inputSplit.TakeWhile(x => x != "");
var movementsPart = inputSplit.Skip(gridPart.Count() + 1);
var movements = movementsPart.SelectMany(x => x.ToArray()).ToArray();

var gridInput = gridPart.Select(x => x.ToArray()).ToArray();
var grid = new List<Node>();
var height = gridInput.Count();
var width = gridInput[0].Count();
for (int y = 0; y < height; y++)
{
    var lastHalf = new Node();
    for (int x = 0; x < width; x++)
    {
        var node = new Node { Icon = gridInput[y][x], X = x, Y = y };
        if (node.Icon == '[')
        {
            lastHalf = node;
        }
        if (node.Icon == ']')
        {
            node.BoxOtherHalf = lastHalf;
            lastHalf.BoxOtherHalf = node;
            lastHalf = null;
        }
        grid.Add(node);
    }
}




var directions = new[] {
    (icon: '>', x: 1, y: 0),
    (icon: '<', x: -1, y: 0),
    (icon: '^', x: 0, y: -1),
    (icon: 'v', x: 0, y: 1),
};

if (print) { PrintGrid(); }
var robot = grid.Single(x => x.Icon == '@');
int i = 0;
foreach (var movement in movements)
{
    Console.WriteLine($"{i} / {movements.Count()}");
    i++;
    var direction = directions.Single(x => x.icon == movement);
    var untilWall = TakeUntilWall(new List<Node>(), robot, direction.x, direction.y).ToList();
    if (!untilWall.All(x => x.Any(y => y.Icon == '.')))
    {
        continue;
    }
    var cells = untilWall.SelectMany(x => x.TakeWhile(y => y.Icon != '.')).Distinct().ToList();

    var newEmpties = new List<Node>();
    var removes = new List<Node>();
    foreach (var node in cells)
    {
        newEmpties.Add(new Node { X = node.X, Y = node.Y, Icon = '.' });

        var newX = node.X + direction.x;
        var newY = node.Y + direction.y;
        removes.Add(grid.SingleOrDefault(x => x.X == newX && x.Y == newY));
        node.X = newX;
        node.Y = newY;
        //if (print) { PrintGrid(); }
    }
    foreach (var item in removes.Except(cells))
    {
        grid.Remove(item);
    }
    foreach (var item in newEmpties.Where(x => !grid.Any(y => x.X == y.X && x.Y == y.Y)).ToList())
    {
        grid.Add(item);
    }

    if (print) { PrintGrid(); }

}

if (print) { PrintGrid(); }


result = grid.Where(x => x.Icon == '[').Sum(x => 100 * x.Y + x.X);

IEnumerable<List<Node>> TakeUntilWall(List<Node> path, Node node, int x, int y)
{
    if (node == null) { yield break; }
    if (node.Icon == '#')
    {
        yield return path;
        yield break;
    }
    path.Add(node);
    if (x == 0)
    {
        var next = grid.SingleOrDefault(n => n.X == node.X + x && n.Y == node.Y + y);
        if ((next.Icon == ']' || next.Icon == '[') && next.BoxOtherHalf == null)
        {

        }
        foreach (var item in TakeUntilWall(path.ToList(), next, x, y).ToList())
        {
            yield return item;
        }
        foreach (var item in TakeUntilWall(path.ToList(), next.BoxOtherHalf, x, y).ToList())
        {
            yield return item;
        }
    }
    else if (y == 0)
    {
        var next = grid.SingleOrDefault(n => n.X == node.X + x && n.Y == node.Y + y);
        foreach (var item in TakeUntilWall(path, next, x, y).ToList())
        {
            yield return item;
        }
    }
}

timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();

void PrintGrid()
{
    var sb = new StringBuilder();
    WriteGrid(sb, grid);
    Console.WriteLine(sb);
}
void WriteGrid(StringBuilder sb, IEnumerable<Node> cache)
{
    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            sb.Append(cache.SingleOrDefault(n => n.X == x && n.Y == y)?.Icon ?? '?');
        }
        sb.AppendLine();
    }
}

class Node
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Icon { get; set; }
    public Node BoxOtherHalf { get; set; }

    public override string ToString() => $"{Icon} {X},{Y}";
}
