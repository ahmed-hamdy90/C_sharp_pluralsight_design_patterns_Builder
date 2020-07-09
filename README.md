#### This Repository Follow Pluralsight course for [C# Builder pattern](https://app.pluralsight.com/library/courses/c-sharp-design-patterns-builder)

##### Problem and Solution files:

You can See project files Example for the Problem and solution which apply Builder pattern Here:
 - Problem at [e0bb60ffd4e355947fa3a8354244476eaebed9c2 commit](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Builder/tree/e0bb60ffd4e355947fa3a8354244476eaebed9c2)
 - Solution: There two solution for applying Builder pattern
    - first solution (main on `master` branch) Using Director class
    which use Builder class to create/complete object instance at [1024dfcde827e4eee4a7f56c93d64493d5d9c4c4 commit](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Builder/tree/1024dfcde827e4eee4a7f56c93d64493d5d9c4c4)
    - second solution (on `fluent-builder-solution` branch) using fluent builder way Like C# built-in `StringBuilder` class, Here 
    [`fluent-builder-solution` branch](https://github.com/ahmed-hamdy90/C_sharp_pluralsight_design_patterns_Builder/tree/fluent-builder-solution)
    

##### Run Problem or Solution Project:
 
 You can Run Project using Docker, if you don't have Docker , you can install Docker Engine from [Here](https://docs.docker.com/engine/install)
 
 - First build docker image
 ```shell
docker build -t builderpattern .
```

 - Second run built image
 ```shell
docker run --name builderpattern builderpattern
``` 