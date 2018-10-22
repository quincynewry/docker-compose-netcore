FROM microsoft/dotnet:2.1-sdk-alpine AS builder

WORKDIR /code

COPY . .
WORKDIR /code

RUN dotnet restore
RUN dotnet publish --output /output -c Release
RUN rm -rf /output/runtimes/win* \
      && rm -rf /output/osx* \
      && rm -rf /output/unix*

FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine
WORKDIR /web
COPY --from=builder /output /web

ENTRYPOINT ["dotnet", "web-1.dll"]
