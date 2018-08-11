package md5cbad293c55ad3d8a5525c823a0541a06;


public class ThirdActivityBinder
	extends android.os.Binder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("my_calender.ThirdActivityBinder, my_calender", ThirdActivityBinder.class, __md_methods);
	}


	public ThirdActivityBinder ()
	{
		super ();
		if (getClass () == ThirdActivityBinder.class)
			mono.android.TypeManager.Activate ("my_calender.ThirdActivityBinder, my_calender", "", this, new java.lang.Object[] {  });
	}

	public ThirdActivityBinder (md5cbad293c55ad3d8a5525c823a0541a06.ThirdActivity p0)
	{
		super ();
		if (getClass () == ThirdActivityBinder.class)
			mono.android.TypeManager.Activate ("my_calender.ThirdActivityBinder, my_calender", "my_calender.ThirdActivity, my_calender", this, new java.lang.Object[] { p0 });
	}

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
