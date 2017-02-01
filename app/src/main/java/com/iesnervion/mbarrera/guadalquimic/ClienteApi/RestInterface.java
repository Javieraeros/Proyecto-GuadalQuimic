package com.iesnervion.mbarrera.guadalquimic.ClienteApi;

import com.iesnervion.mbarrera.guadalquimic.Model.Alumno;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Header;

/**
 * Created by mbarrera on 1/02/17.
 */

public interface RestInterface {

    @GET("alumno")
    Call<Alumno> getLogin(@Header("Authorization") String auth);
}
