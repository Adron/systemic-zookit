# OSSing Zookit & Zoodock

The project(s) I'd currently like to open source include the following two libraries/projects.

1. systemic-zookit
* systemic-dockzoo

## Project *systemic-zookit*

This project is setup with an Apache-2.0 License and currently building with Team City and Travis CI. Both builds are working and the project is ready for ongoing development.

### Mission

The mission of this project is to provide an IConfiguration based library for use in standard .NET Applications, and specifically for eventual build and operation with any future Core CLR Platform Development.

### Core Functionality

The project will provide the following functions/method calls from several objects that meets the IConfiguration contract.

TODO: Working on writing up a description of use.

### Value to the Community

This project will provide an interface contract that any developer using .NET can pull into a project and use Zookeeper with. It provides this standard interface so that Zookeeper complexities are managed almost exclusively by the underlying code and the contract provides just a simple set of methods to call into and put data into the Zookeeper Cluster.

## Project *systemic-dockzoo*

This project is the DockerFile and respective scripts needed to startup a cluster built of Docker Containers using Ubuntu to run Zookeeper with Exhibitor (Netflix's Zookeeper Web Interface). This cluster can then be used for further development and currently for any test execution of the Zookit library.

### Mission

The mission of this project is to provide a Zookeeper testing environment (instance containers) to develop and test.

### Core Functionality

This project is built around Docker technologies, using a Dockerfile to build a Docker image that runs Zookeeper. This image is good for testing and development purposes but not particularly production use.

* Docker Image w/ Zookeeper
* Start container w/ "docker run -it image-name bash" TODO: Add specifics for port #s etc.

### Value to the Community

This project will provide a development and testing Zookeeper instance for use with systemic-zookit, but will also provide a good Zookeeper install to test other tools, interfaces, and utilities also. Such as Netflix's Exhibitor user interface for Zookeeper, configuration management for other applications, and related tooling.