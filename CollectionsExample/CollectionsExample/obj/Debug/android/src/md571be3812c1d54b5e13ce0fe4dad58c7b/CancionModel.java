package md571be3812c1d54b5e13ce0fe4dad58c7b;


public class CancionModel
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_toString:()Ljava/lang/String;:GetToStringHandler\n" +
			"";
		mono.android.Runtime.register ("CollectionsExample.CancionModel, CollectionsExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CancionModel.class, __md_methods);
	}


	public CancionModel ()
	{
		super ();
		if (getClass () == CancionModel.class)
			mono.android.TypeManager.Activate ("CollectionsExample.CancionModel, CollectionsExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public java.lang.String toString ()
	{
		return n_toString ();
	}

	private native java.lang.String n_toString ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
