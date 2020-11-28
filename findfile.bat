@echo off
set filepath=D:\Jenkins\workspace\VBProgrammingClub\ProgrammingClub\ProgrammingClub.Tests\TestResults
set outputpath=D:\Jenkins\workspace\VBProgrammingClub\ProgrammingClub\ProgrammingClub.Tests\
echo %filepath%
D:
cd %filepath%
echo where /r %filepath% vstest.coverage 
rem set CodeCoverage=<where /r %filepath% vstest.coverage 
for /f "delims=" %%i in ('where /r %filepath% vstest.coverage') do set CodeCoverage=%%i
echo %CodeCoverage% 
copy %CodeCoverage% %outputpath%
C:
echo DONE