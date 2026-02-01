FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

COPY . /app

RUN dotnet publish Contoso.Spaces.Web.csproj --configuration Release --output out

FROM nginx:alpine

COPY --from=build /app/out/wwwroot /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf

EXPOSE 80