#r "nuget: Fun.Build"

open Fun.Build


pipeline "setup" {
    stage "setup remote debug" {
        run "scp bin/Debug/net7.0 pi@192.168.3.48:~/Playground/RemoteDebug"
    }
}