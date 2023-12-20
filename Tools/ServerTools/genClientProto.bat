@echo off

echo ******GenClientProto Begin ******

set ProtoLocalPath= "ProtoLocalPath"
set ClientProtoOutPath= "ClientProtoOutPath"

for /f "tokens=1,2 delims==" %%i in (conf.ini) do (
    if %%i==ProtoLocalPath set ProtoLocalPath=%%j
    if %%i==ClientProtoOutPath set ClientProtoOutPath=%%j
    )
for /f "delims=" %%i in ('dir /b %~dp0%ProtoLocalPath%"\proto\*.proto"') do %~dp0%ProtoLocalPath%\protoc -I=%~dp0%ProtoLocalPath%\proto\ --csharp_out=%~dp0%ClientProtoOutPath% %~dp0%ProtoLocalPath%\proto\%%i

echo ******GenClientProto Finsh ******


