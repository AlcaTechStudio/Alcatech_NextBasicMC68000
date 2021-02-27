@echo off
"%cd%\compiler\NEXTBASIC.exe" "%cd%\main.vb" -rFF0000 -sFFFFFF -a -v
echo.
rem echo iniciando emulador...
"%cd%\emu\gens.exe" "%cd%\main.bin"
