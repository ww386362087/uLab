
local gameObject;
local transform;

BarWindow = {};
--local this = BarWindow;

function BarWindow.Awake(obj)
	gameObject = obj;
	transform = obj.transform;
	BarWindow.Init();
end

function BarWindow.Init()
	--this.btnOpen = transform:FindChild("open").gameObject;
	Log.Error("BarWindow~");
end
