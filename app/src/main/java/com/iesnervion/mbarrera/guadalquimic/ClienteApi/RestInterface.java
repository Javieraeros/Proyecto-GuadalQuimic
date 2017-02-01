package com.iesnervion.mbarrera.guadalquimic.ClienteApi;

import com.iesnervion.mbarrera.guadalquimic.Models.Alumno;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Header;

/**
 * Created by mbarrera on 1/02/17.
 */

public interface RestInterface {

    @GET("login")
    Call<Alumno> getLogin(@Header("Authorization") String auth);
}
