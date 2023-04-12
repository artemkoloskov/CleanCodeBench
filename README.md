# CleanCodeBench

This a C# recreation of a *Clean code - BAD* case from Casey Muratori's [video](https://www.youtube.com/watch?v=tD5NrevFtbU).

Small addition, i also tried to explore the impact of separating code into multiple files (wich seems to be none).

The results are as follows:

| Method | Mean | Error | StdDev | Allocated |  
|---------------------------------------- |----------:|----------:|----------:|----------:|  
| CleanCodeShapesAreaAndOtherProps | 13.003 ns | 0.2126 ns | 0.1775 ns | - |  
| CleanCodeShapesArea | 6.375 ns | 0.0737 ns | 0.0653 ns | - |  
| CleanCodeOneFileShapesAreaAndOtherProps | 13.515 ns | 0.2052 ns | 0.1920 ns | - |  
| CleanCodeOneFileShapesArea | 6.437 ns | 0.1334 ns | 0.2192 ns | - |  
| SimpleShapesAreaAndOtherProps | 7.120 ns | 0.2138 ns | 0.5925 ns | - |  
| SimpleShapesArea | 4.125 ns | 0.0584 ns | 0.0488 ns | - |
