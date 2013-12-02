ExampleWcf
==========

Simple WCF example with a fictitious RecordsKeeper transaction system

Taken from email to Ned on Dec 2nd 2013:

I have been exploring some intranet/internet communication options relative 
to the scenario we spoke about during the interview.  As it turns out .NET 
makes this as frictionless as possible to learn and implement using the 
Windows Communication Foundation.

I created a very simple IRecordsKeeper interface that creates typical 
contracts that could be necessary during a payment transaction.  I 
then implemented this interface in a RecordsKeeper library (of course 
I took this opportunity to use a Sorted collection), created a host and 
lastly created a client.

https://github.com/sscapicchio/ExampleWcf

Currently these are based on a WSHttpBinding which would be very effective 
for the server to back-end scenario but not effective as the register/server 
scenario we discussed.  However, the bindings are configurable and 
NetTcpBinding() would be a great option for this register/sever scenario.

Obviously this would not be appropriate for a real-life situation.  I 
was just trying to learn basic concepts.  I would be happy to discuss the tradeoffs 
I made as wells as the concepts I found available.


To Run:
1.  Make sure VS2012 is opened in Admin mode (right click on VS2012 and run as admin).
2.  Build solution.
3.  Set 'ExampleWcfHost' as startup project.
4.  Run without debugging (ctrl-f5)
5.  Set 'ExampleWcfClient' as startup project.
6.  Run with or without debugging (f5 or ctrl-f5).  If you run with debugging you will get 
    warnings that the host will not allow you to step into code.
	
To change locations:

Both projects contain a config that will override the default locations.  The most interesting
would be to run the client from a different PC.  In this case change the endpoint address from 
'localhost' to the IP address that ExampleWcfHost is running. 

Config file is:
>> ExampleWcfClient.exe.config

