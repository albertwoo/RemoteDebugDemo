## Password access by ssh

https://www.raspberrypi.com/documentation/computers/remote-access.html#passwordless-ssh-access

- open windows terminal: ssh-keygen
- copy the id_rsa.pub to pi's ~/.ssh/authorized_keys


## Setup project

https://learn.microsoft.com/en-us/dotnet/iot/debugging?tabs=self-contained&pivots=vscode

- Install remote debugger: curl -sSL https://aka.ms/getvsdbgsh | /bin/sh /dev/stdin -v latest -l ~/vsdbg
- Install dotnet sdk
- Follow the launch.json and tasks.json
