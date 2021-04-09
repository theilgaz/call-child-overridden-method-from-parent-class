# call-child-overridden-method-from-parent-class
when foo is called from the child class, child's bar will be called, instead of parent's


## Flow


#### Entrypoint
MyForm.Ctor

#### Steps
1. Call Child.ExecuteOrder666() method in MyForm.Ctor().
2. This method will execute Base.Call().
3. Base.Call() will execute Base.Foo().
4. Base.Foo() will execute Child.Foo().
5. MessageBox will raise for "Called Child.Foo"
