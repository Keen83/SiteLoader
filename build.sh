#!bin/bash
set -e
dotnet restore
rm -rf $(pwd)/publish/web
dotnet publish -c Release -o $(pwd)/publish/web