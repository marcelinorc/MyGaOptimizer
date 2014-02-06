This simple example shows the use of a plug-in framework 
inspired on Equinox to optimize functions using a Fast Messy 
implementation. The Plug-in framework allows to define 
multiple extension points and contributions to these points.
Each plug-in may contain Extension Points, Contribution or both.

In this example in particular we will have two extension points:
1. Objective functions
2. Objective function parameters.

The objective functions parameters extension point will accept factory classes 
to create widgets. These widgets are responsible to input data 
given the type of the parameter.

In Project Functions1 the extension point for the objetive 
functions are defined. In Project Functions2 new objecive functions
are defined as contributions, simulating third party contributions.

WidgetsPlugins provide both extension point and contributions.
