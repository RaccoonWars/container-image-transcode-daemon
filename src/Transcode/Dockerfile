FROM mcr.microsoft.com/dotnet/runtime:3.1

SHELL ["/bin/bash", "-c"]
RUN apt-get update && \
    apt-get upgrade -y

RUN apt-get install -y \
    git \
    build-essential \
    ffmpeg \
    libpcre3 \
    libpcre3-dev \
    libssl-dev \
    zlib1g-dev \
    wget

COPY bin/Release/netcoreapp3.1/publish /app
WORKDIR /app
ENTRYPOINT ["dotnet", "Transcode.dll"]