# TODO next

- unit tests
- filesystem
- appsettings
- ui (command line only)

## SonaQube

- [SonarQube](h) is installed on apollo

```bash
# install [SonarQube](https://github.com/anttieskola/setup/blob/main/installation.md#sonarqube)

# install the dotnet scanner (only once per machine)
dotnet tool install --global dotnet-sonarscanner

# create project in SonarQube named "iPhone-mutations"

# Start analysis (file should be already the ignore i use)
dotnet sonarscanner begin \
  /k:"iPhone-mutations" \
  /d:sonar.host.url="http://localhost:9000" \
  /d:sonar.login="$SONAR_TOKEN" \
  /d:sonar.cs.opencover.reportsPaths="**/coverage.opencover.xml"

# Build your solution
dotnet build

# End analysis
dotnet sonarscanner end /d:sonar.login="$SONAR_TOKEN"

# open browser to see the results
firefox http://localhost:9000/dashboard?id=iPhone-mutations

# if all works out just add command to run it
```
