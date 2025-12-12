dotnet build ./Bawstudios.OS27.csproj -p:TargetFramework=net10.0 -p:DisableAndroidTFM=true
dotnet publish ./Bawstudios.OS27.csproj -c Release -r linux-x64 -p:TargetFramework=net10.0 -p:DisableAndroidTFM=true /p:NativeLib=Shared /p:SelfContained=true 
