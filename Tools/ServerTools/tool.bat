@echo off
::提示询问
:activated
echo ====================================================
echo ====================================================
echo ====================================================
echo ====================================================
echo   1       Start Server
echo   2       Stop Server
echo   3       GenAllProto
echo   4       Exit


set /p commandActivated=Please Enter:
if "%commandActivated%"=="1" (goto startServer) else if "%commandActivated%"=="2" (goto stopServer) else if "%commandActivated%"=="3" (goto genAllProto) else (goto exitCmd)

::启动服务器
:startServer
call startServer.bat
goto activated

::关闭服务器
:stopServer
call stopServer.bat
goto activated

::genAllProto
:genAllProto
call genClientProto.bat
call genServerProto.bat
goto activated

::exit
:exitCmd
