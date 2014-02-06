MyGaOptimizer
=============

The project consists in a demonstrative platform. Such demonstrative platform uses the plug-in framework I programmed for WatDis (gently released as open source by Transparent Blue) to dynamically find objective functions for a GA optimizer. It also dynamically searches for widget factories to construct interfaces for these functions.  

Objective functions and widget factories are the  two extension points of the platform, although the plug-in framework allows to include as many extension points as needed. The platform is largely inspired in Equinox and Envisage and uses a subset of the same concepts and principles. 

The plug-ins projects defining new functions are "Function1" and "Function2". The plug-in project defining widget factories are "WidgetsFactoryPlugins".

Later, once all functions are loaded, their parameters are obtained by means of reflection. This information is used to create a (very simple) user interface to pass parameters to the function.
