@echo off
cmake -B "vs2022_x64_double" -S "./../" -G "Visual Studio 17 2022" -A x64 -DCMAKE_INSTALL_PREFIX:String="SDK" -DDOUBLE_PRECISION=ON %*
echo Open vs2022_x64_double\JoltC.sln to build the project.