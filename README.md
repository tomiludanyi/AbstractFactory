# AbstractFactory

The program is representing an automatized car factory producing different type of VW cars.
Its architecture is based on the Abstract Factory design pattern.
The supported car models are: VW Golf, VW Passat and VW Polo.
The manufacturing process for a car is as follows: preparation of the carrosserie, production of the steering gear, production of the engine, and finally, the assembly.
All parts are uniformly supported with a diagnose operation, which throws an exception if the created part is not as expected.
The alarm system is implemented using the Singleton design pattern during the simulation.
It displays error parameters in red color on the console.
