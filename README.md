# Facebook App
Basic Facebook Features is a C# application that integrates with Facebook's API to provide a set of features using object-oriented design patterns. This project demonstrates the application of the Observer, Strategy, and Factory patterns in a social media context. Users can log in, post status updates, and schedule posts to be published later.


## Overview
This project showcases several design patterns implemented in a Facebook API context, where the user interacts with Facebook using various features:

LoginObserver: Observes and notifies when the user successfully logs in to Facebook.

NormalPostStrategy: Posts a normal status update on Facebook.

ScheduledPostStrategy: Schedules a status update to be posted at a specific time in the future.

SpecialFeaturesFactory: A factory that creates instances of special features like scheduled posts and top 5 liked pages.


## Features
Login Observer: Allows observers to subscribe and be notified when a user logs in via Facebook.

Normal Post Strategy: Enables users to post regular status updates to Facebook.

Scheduled Post Strategy: Lets users schedule posts to be published at a specific time.

Special Features Factory: Provides factory methods for creating special features like scheduled posts and top 5 liked pages.


## Technologies Used
C#: The primary programming language for this project.

Facebook API: Used for authenticating users and posting statuses.

Windows Forms: For building the user interface (UI).

Design Patterns: Implemented Observer, Strategy, and Factory patterns to achieve modularity and scalability.

FacebookWrapper: A wrapper around the Facebook Graph API that simplifies interacting with Facebook.
