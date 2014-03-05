MvcFireAndForgetIssue
=====================

Sample to demonstrate a possible issue with async

It causes a null ref exception in System.Web:

```
>	System.Web.dll!System.Web.ThreadContext.AssociateWithCurrentThread(bool setImpersonationContext)	Unknown
 	System.Web.dll!System.Web.HttpApplication.OnThreadEnterPrivate(bool setImpersonationContext)	Unknown
 	System.Web.dll!System.Web.HttpApplication.System.Web.Util.ISyncContext.Enter()	Unknown
 	System.Web.dll!System.Web.Util.SynchronizationHelper.SafeWrapCallback(System.Action action)	Unknown
 	System.Web.dll!System.Web.Util.SynchronizationHelper.QueueAsynchronous.AnonymousMethod__7(System.Threading.Tasks.Task _)	Unknown
 	mscorlib.dll!System.Threading.Tasks.ContinuationTaskFromTask.InnerInvoke()	Unknown
 	mscorlib.dll!System.Threading.Tasks.Task.Execute()	Unknown
 	mscorlib.dll!System.Threading.Tasks.Task.ExecutionContextCallback(object obj)	Unknown
 	mscorlib.dll!System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, object state, bool preserveSyncCtx)	Unknown
 	mscorlib.dll!System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, object state, bool preserveSyncCtx)	Unknown
 	mscorlib.dll!System.Threading.Tasks.Task.ExecuteWithThreadLocal(ref System.Threading.Tasks.Task currentTaskSlot)	Unknown
 	mscorlib.dll!System.Threading.Tasks.Task.ExecuteEntry(bool bPreventDoubleExecution)	Unknown
 	mscorlib.dll!System.Threading.Tasks.Task.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()	Unknown
 	mscorlib.dll!System.Threading.ThreadPoolWorkQueue.Dispatch()	Unknown
 	mscorlib.dll!System.Threading._ThreadPoolWaitCallback.PerformWaitCallback()	Unknown
 	[Native to Managed Transition]	
```
