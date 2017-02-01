package com.iesnervion.mbarrera.guadalquimic.ClienteApi;

import android.content.Context;
import android.widget.Toast;

import com.iesnervion.mbarrera.guadalquimic.Models.Alumno;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

/**
 * Created by mbarrera on 1/02/17.
 */

public class AlumnoCallback implements Callback<Alumno>{

    private InterfazComunicadora enviador;
    private Context miContexto;

    public  AlumnoCallback(Context miContexto){
        this.miContexto=miContexto;
        if (miContexto instanceof InterfazComunicadora) {
            enviador = (InterfazComunicadora) miContexto;
        } else {
            throw new RuntimeException(miContexto.toString()
                    + " must implement InterfazComunicadora");
        }
    }
    @Override
    public void onResponse(Call<Alumno> call, Response<Alumno> response) {
       /* List<Persona> miLista=response.body();
        Persona[] miArrayPersona=new Persona[miLista.size()];
        miLista.toArray(miArrayPersona);
        enviador.cuandoAcabe(miArrayPersona);*/
        if(response.code() == 200){
            Alumno alumno = new Alumno();

            enviador.cuandoAcabeGetLogin(alumno);

        }else {

        }
    }

    @Override
    public void onFailure(Call<Alumno> call, Throwable t) {
        Toast.makeText(miContexto,"Argo ha fallao picha", Toast.LENGTH_SHORT).show();
    }
}
