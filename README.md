# **Strategy Pattern in Unity:**

## **What is the Strategy Pattern?**

The Strategy Pattern is a behavioral design pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable. It allows a client to choose an appropriate algorithm at runtime, effectively decoupling the implementation of an algorithm from its usage.

![image](https://github.com/iAmSidh108/DP_StrategyPattern/assets/63715240/b4674a85-922c-469d-bd8b-022bb110df11)


## **Examples of using the Strategy Pattern in game development:**

1. **Enemy AI Behavior:**
   - **Strategies:** Different enemy behavior algorithms, such as aggressive, defensive, or passive.
   - **Context:** The enemy object with a strategy interface reference.
   - **Client Code:** Dynamically sets the enemy's behavior strategy at runtime.

2. **Sorting Algorithms:**
   - **Strategies:** Different sorting algorithms (e.g., bubble sort, quicksort).
   - **Context:** A sorting manager class with a reference to a sorting strategy.
   - **Client Code:** Allows switching between sorting strategies based on different requirements.

## **Drawbacks of using Strategy Pattern:**

1. **Complexity:**
   - The pattern can lead to a larger number of classes and may introduce complexity, especially for simple systems.

2. **Client Responsibility:**
   - Clients need to understand the various strategies and choose the appropriate one, which may not always be desirable.

3. **Increased Number of Objects:**
   - The pattern can lead to an increased number of objects, especially if each strategy requires its own class.

## **How to implement Strategy Pattern:**

![image](https://github.com/iAmSidh108/DP_StrategyPattern/assets/63715240/5c38b08f-9479-48f7-8804-8b1e0fe458dc)


1. **Define Strategy Interface:**
   - Create an interface or abstract class defining the methods that represent the different strategies.

2. **Implement Concrete Strategies:**
   - Develop concrete classes that implement the strategy interface, representing different algorithmic behaviors.

3. **Context Class:**
   - Create a context class that holds a reference to the strategy interface, allowing it to switch between different strategies.

4. **Client Code:**
   - In client code, set or switch the strategy for the context object based on dynamic requirements.

5. **Unity Input System:**
   - In Unity, the Input System can be considered a form of the strategy pattern, where different input schemes (e.g., keyboard, controller) are encapsulated as strategies.

6. **Dynamic Difficulty Adjustment:**
   - In game development, the Strategy Pattern can be applied to dynamically adjust the difficulty level by changing AI behavior or game mechanics based on player performance.

7. **Documentation:**
   - Clearly document the purpose and usage of each strategy and the context, making it easier for developers to understand and maintain the system.

## **Real-life Example:**

Consider a transportation app where users can select different routes based on preferences like fastest, cheapest, or most scenic. The app uses the Strategy Pattern, where each route-finding algorithm (fastest, cheapest, scenic) is encapsulated as a strategy. The user can dynamically choose the desired strategy at runtime, allowing for a flexible and interchangeable approach to route selection. This demonstrates how the Strategy Pattern can be applied in real-life scenarios to provide users with various algorithmic options.

![image](https://github.com/iAmSidh108/DP_StrategyPattern/assets/63715240/8dacc7e6-3297-44b9-90e5-72927c91552a)


## How I implemented this pattern into this project?

To create Strategy class we can either use abstract class or interface. We have used both in the game. For Gun System, we used ABstract class and for different projectiles we used interface. 
### For Gun System

We created an abstract class called weapon base and created a method called shoot that each inherited class must implement. After that we create different guns like single shot and burst shot and implement shooting mechanism accordingly. And finally we created a GunSystem that will be attached to player and hold reference to weaponBase and we can swap different guns at the runtime.

### For Projectile System
We created an interface called IMovable with Move method and implemented into all types of projectiles like accleratedMovementProjectile, linearMovementProjectile and noMovement. Added codes to make desired movement and then there is a Startegy class called Projectile.cs which has reference of IMovable and can be swapped according to the guns and thus produce different bullets as per the guns.

In the weapon system we write code to fire differnt projectiles based on their their guns.
