@echo off

echo ******GenServerProto Begin ******

set ProtoLocalPath= "ProtoLocalPath"
set ServerProtoOutPath= "ClientProtoOutPath"

for /f "tokens=1,2 delims==" %%i in (conf.ini) do (
    if %%i==ProtoLocalPath set ProtoLocalPath=%%j
    if %%i==ServerProtoOutPath set ServerProtoOutPath=%%j
    )
for /f "delims=" %%i in ('dir /b %~dp0%ProtoLocalPath%"\proto\*.proto"') do %~dp0%ProtoLocalPath%\protoc -I=%~dp0%ProtoLocalPath%\proto\ --java_out=%~dp0%ServerProtoOutPath% %~dp0%ProtoLocalPath%\proto\%%i

echo ******GenServerProto Finsh ******


