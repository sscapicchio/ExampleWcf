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
