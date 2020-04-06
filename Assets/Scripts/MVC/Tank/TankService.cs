using UnityEngine;

public class TankService : MonoBehaviour
{
    public TankView tankView;
    private void Start()
    {
        TankModel model = new TankModel(5, 100f);
        TankController tank = new TankController(model, tankView);
    }
}
