﻿let sw = new System.Diagnostics.Stopwatch()

let filename = "./input/day14.txt"

sw.Restart()
let s1 = Day14.solve1 filename
printfn "%O (%O)" s1 sw.Elapsed

sw.Restart()
let s2 = Day14.solve2 filename
printfn "%O (%O)" s2 sw.Elapsed
