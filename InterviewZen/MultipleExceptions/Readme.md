Consider the following code snippet:

 ```csharp
    public void CacheDataToFile()
	{
	  MyDataReader reader = this.GetDataReader();
  
	  this.SaveToFile(reader, "SomeFileName.dat");
  
	  this.Logger.Write("File saved successfully");
  
	  reader.Close();
	}
 ```

You want to write code to handle exceptions according to the following rules:
+ If an exception of type UserFriendlyException is caught, you just want to propagate it to the caller method.
+ If an exception of type FileAlreadyExistsException is caught, you want to write a message to the log and continue execution normally
+ If any other type of exception is caught, you want to throw a new exception of type UserFriendlyException, with the message "Unable to save data to cache" and keep the original exception in the InnerException property of the new exception being thrown.
+ Regardless of any exception being thrown, the reader.Close() method must always be called
  
Make the necessary changes to the CacheDataToFile method.