
using Lite.Strategy;


namespace Lite
{

	public class EntityFactory : Singleton<EntityFactory>
	{

		public Agent CreateAgent(Career career, int x, int y, int z)
		{
			Agent agent = new Agent(GuidGenerator.NextLong(), career);
			agent.name = career.ToString();
			agent.x = x;
			agent.y = y;
			agent.z = z;

			AppFacade.Instance.stgAgentManager.AddAgent(agent);
			// sync to bev
			return agent;
		}

	}

}