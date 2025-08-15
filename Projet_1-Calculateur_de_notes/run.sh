#!/bin/bash

echo "🔧 Compilation en cours..."
dotnet publish ./Note_Calculator.Cli/Note_Calculator.Cli.csproj -c Release -r linux-x64 --self-contained true -o ./publish

echo "🚀 Lancement de l'application..."
gnome-terminal --geometry=61x32 -- ./publish/Note_Calculator.Cli