namespace People;

public partial class App : Application
{
	public static PersonRepository PersonRepo { get; private set; }

	public App(PersonRepository Person)
	{
		InitializeComponent();
		// TODO: Initialize the PersonRepository property with the PersonRespository singleton object
		PersonRepo=Person;

	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		return new Window(new AppShell());
	}
}