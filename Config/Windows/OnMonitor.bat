@echo off
@color f0

echo Powering on monitors
rem Setup Device
mode com1: baud=9600 data=8 parity=n stop=1
rem Send bytes
echo PWR ON > COM1
pause
