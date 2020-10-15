# CharpBook
Create hml book from markdown documents

Build a single exe  command 

```shell 
dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true
```

Trim non used dll from exe 
```shell 
dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true
```
