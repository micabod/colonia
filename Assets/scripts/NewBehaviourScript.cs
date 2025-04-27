using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int inscriptosJuveniles;
    public int inscriptosInfantiles;
    int profesoresJuveniles;
    int profesoresInfa;
    int coordinadores;
    int listajuve;
    int listainfa;
    int totprofes;
    // Start is called before the first frame update
    void Start()
    {
        if(inscriptosJuveniles<0 || inscriptosJuveniles>100 || inscriptosInfantiles<0 || inscriptosInfantiles>100){
            Debug.Log("Error: formato invalido");
            return;
        }
        profesoresJuveniles= inscriptosJuveniles/20;
        profesoresInfa = inscriptosInfantiles/10;
        totprofes=profesoresJuveniles + profesoresInfa;
        Debug.Log("Se necesitan "+profesoresJuveniles+" para los inscriptos juveniles");
        Debug.Log("Se necesitan "+profesoresInfa+" para los inscriptos infantiles");
        coordinadores= totprofes/5;
        if (totprofes%5!=0){
            coordinadores= coordinadores + 1;

        }
        Debug.Log("se necesitan"+coordinadores+" coordinadores");
        listajuve = inscriptosJuveniles - (20 * profesoresJuveniles);
        listainfa = inscriptosInfantiles - (10 * profesoresInfa);
        int listafinal= listajuve + listainfa;
        Debug.Log("la cantidad de personas en lista de espera es de "+ listafinal);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
